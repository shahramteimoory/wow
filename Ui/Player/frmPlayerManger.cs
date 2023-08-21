using DataLayer.Context;
using Fury.Player;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Ui.Player
{
    public partial class frmPlayerManger : Form
    {
        public frmPlayerManger()
        {
            InitializeComponent();
        }

        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayerList.AutoGenerateColumns = false;
                dgvPlayerList.DataSource = db.PlayerRepository.GetAllPlayer();
                db.Dispose();
            }
        }
        private void frmPlayerManger_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void btnInsertPlayer_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int count = db.PlayerRepository.GetCount(txtInsertPlayer.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Player Already Excist");
                        return;
                    }
                    else
                    {
                        DataLayer.Player player = new DataLayer.Player()
                        {
                            FullName = txtInsertPlayer.Text,
                            IsDelete = false,
                        };
                        db.PlayerRepository.InsertPlayer(player);
                        db.Save();
                    }
                    txtInsertPlayer.Text = null;
                    frmRefresh();
                    db.Dispose();
                }

            }
        }

        private void btnPlayerSearch_Click(object sender, EventArgs e)
        {



        }

        private void dgvPlayerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                //delete
                DialogResult dialogResult = MessageBox.Show("Are u sure for Soft Remove " + dgvPlayerList.Rows[e.RowIndex].Cells[1].Value + "?", "Soft Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int playerid = int.Parse(dgvPlayerList.CurrentRow.Cells["PlayerID"].Value.ToString());
                        db.PlayerRepository.SoftDeletePlayer(playerid);
                        db.Save();
                        frmRefresh();
                        db.Dispose();
                        txtPlayerSearch.Text = "";
                        MessageBox.Show("Player Soft Deleted");
                    }
                }
            }
            //Edit
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                frmEditPlayer frmEditPlayer = new frmEditPlayer();
                frmEditPlayer.txtEdit.Text = dgvPlayerList.Rows[e.RowIndex].Cells["clmPlayer"].Value.ToString();
                DialogResult dialogResult = frmEditPlayer.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    if (frmEditPlayer.txtEdit.Text != "")
                    {
                        int playerid = int.Parse(dgvPlayerList.CurrentRow.Cells["PlayerID"].Value.ToString());
                        string playername = frmEditPlayer.txtEdit.Text;

                        using (UnitOfWork db = new UnitOfWork())
                        {
                            DataLayer.Player player = new DataLayer.Player()
                            {
                                PlayerID = playerid,
                                FullName = playername,
                                IsDelete = false,
                            };
                            db.PlayerRepository.UpdatePlayer(player);
                            db.Save();
                            frmRefresh();
                            db.Dispose();
                        }
                    }
                }
            }
        }

        private void txtPlayerSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtPlayerSearch.Text != "")
                {
                    dgvPlayerList.DataSource = db.PlayerRepository.Search(txtPlayerSearch.Text);
                }

                else
                {
                    frmRefresh();
                    db.Dispose();
                }
            }
        }

        private void btnHardDeletePlayer_Click(object sender, EventArgs e)
        {
            frmHardDeletePlayer frmHardDeletePlayer = new frmHardDeletePlayer();
            frmHardDeletePlayer.ShowDialog();
            frmRefresh();
        }

        private void btnRecoveryPlayer_Click(object sender, EventArgs e)
        {
            frmRecoveryPlayer frmRecoveryPlayer = new frmRecoveryPlayer();
            frmRecoveryPlayer.ShowDialog();
            frmRefresh();
        }
    }
}
