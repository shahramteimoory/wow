using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ui.Boost
{
    public partial class frmBoostEdit : Form
    {
        private bool IsLoad;
        private DateTime BoostDate;
        public frmBoostEdit()
        {
            InitializeComponent();
        }
        public int Boostid;

        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                var boost = db.BoostRepository.GetBoostById(Boostid);
                txtGoldPot.Text = boost.Gold.ToString();
                cbDungeonLvl.Text = boost.Lvl.ToString();
                cbDungeonName.Text = boost.Dungeon.Name;
                chbOwner.Checked = boost.Mine;
                IsLoad = true;
                lblAdvID.Text = boost.PlayerID.ToString();
                lblAdvName.Text = $"Advertiser: {boost.Player.FullName}";
                BoostDate = boost.DateTime;
               if(boost.IsGold == true)
                {
                    rbGold.Checked = true;
                }
               else
                {
                    rbMoney.Checked = true;
                }
                var run = boost.Run;
                dgvRuns.Rows.Clear();
                foreach (var item in run)
                {
                    dgvRuns.Rows.Add(item.RunID, item.PlayerID, item.RoleID, item.Player.FullName, item.Role.Title, item.Gold);
                }
                db.Dispose();
            }
        }
        private void frmBoostEdit_Load(object sender, EventArgs e)
        {
            IsLoad = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayers.AutoGenerateColumns = false;
                dgvPlayers.DataSource = db.PlayerRepository.GetAllPlayer();

                List<ViewModel.Dungeon.DungeonViewModel> List = new List<ViewModel.Dungeon.DungeonViewModel>();
                List.AddRange(db.DungeonRepository.GetNameDungeons());
                cbDungeonName.DataSource = List;
                cbDungeonName.DisplayMember = "Name";
                cbDungeonName.ValueMember = "DungeonID";
                db.Dispose();
            }
            frmRefresh();

        }

        private void dgvRuns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    dgvRuns.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void btnSelectRole_Click(object sender, EventArgs e)
        {
            DPS.BorderStyle = BorderStyle.None;
            HEAL.BorderStyle = BorderStyle.None;
            TANK.BorderStyle = BorderStyle.None;

            Panel panel = new Panel();
            panel = (Panel)sender;
            panel.BorderStyle = BorderStyle.Fixed3D;

        }

        private void chbOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (IsLoad)
            {
                if (chbOwner.Checked)
                {
                    lblAdvID.Text = "0";
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        DataLayer.Player player = db.PlayerRepository.GetPlayerById(0);
                        lblAdvName.Text = $"Advertiser: {player.FullName}";
                    }
                }
                else
                {
                    Player.frmSelectPlayer form = new Player.frmSelectPlayer();
                    DialogResult dialogResult = form.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        lblAdvName.Text = $"Advertiser: {form.lblName.Text}";
                        lblAdvID.Text = form.lblID.Text;
                        
                        if (lblAdvID.Text == "0")
                        {
                            chbOwner.Checked = true;
                        }
                    }
                    else
                    {
                        chbOwner.Checked = true;
                    }
                }
            }
        }

        private void dgvPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string RoleName;
            int RoleID;
            if (DPS.BorderStyle == BorderStyle.Fixed3D)
            {
                RoleName = "DPS";
                RoleID = 2;
            }
            else if (TANK.BorderStyle == BorderStyle.Fixed3D)
            {
                RoleName = "TANK";
                RoleID = 1;
            }
            else
            {
                RoleName = "HEAL";
                RoleID = 3;
            }


            if (e.RowIndex != -1 && e.ColumnIndex == 2)
            {
                dgvRuns.Rows.Add(null, dgvPlayers.Rows[e.RowIndex].Cells[0].Value, RoleID, dgvPlayers.Rows[e.RowIndex].Cells[1].Value, RoleName);
                ComputeCut();
            }
        }

        private void ComputeCut()
        {
            if (chbAutoCompute.Checked)
            {
                if (string.IsNullOrEmpty(txtGoldPot.Text))
                {
                    for (int i = 0; i < dgvRuns.Rows.Count; i++)
                    {
                        dgvRuns.Rows[i].Cells[5].Value = 0;
                    }
                }
                else
                {
                    if (dgvRuns.Rows.Count != 0)
                    {
                        long perPlayer = long.Parse(txtGoldPot.Text) / dgvRuns.Rows.Count;

                        for (int i = 0; i < dgvRuns.Rows.Count; i++)
                        {
                            dgvRuns.Rows[i].Cells[5].Value = perPlayer;
                        }
                    }
                }

                dgvRuns.Columns[5].ReadOnly = true;
            }
            else
            {
                for (int i = 0; i < dgvRuns.Rows.Count; i++)
                {
                    dgvRuns.Rows[i].Cells[5].Value = 0;
                }
                dgvRuns.Columns[5].ReadOnly = false;
            }
        }

        private void txtGoldPot_TextChanged(object sender, EventArgs e)
        {
            ComputeCut();
        }

        private void dgvRuns_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ComputeCut();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {

                db.RunRepository.DeleteRuns(Boostid);
                db.Save();
                db.Dispose();
            }

            using (UnitOfWork db = new UnitOfWork())
            {

                db.BoostRepository.DeleteBoost(Boostid);
                db.Save();
                db.Dispose();
            }

            using (UnitOfWork db = new UnitOfWork())
            {
                DataLayer.Boost boost = new DataLayer.Boost();

                boost.PlayerID = int.Parse(lblAdvID.Text);
                boost.DateTime = BoostDate;
                boost.Gold = long.Parse(txtGoldPot.Text);
                boost.Lvl = int.Parse(cbDungeonLvl.SelectedItem.ToString());
                boost.DungeonID = int.Parse(cbDungeonName.SelectedValue.ToString());
                boost.Mine = chbOwner.Checked;
                if (rbGold.Checked)
                {
                    boost.IsGold = true;
                }
                else
                {
                    boost.IsGold= false;
                }
                List<DataLayer.Run> runs = new List<DataLayer.Run>();

                for (int i = 0; i < dgvRuns.Rows.Count; i++)
                {
                    DataLayer.Run run = new DataLayer.Run();
                    run.PlayerID = int.Parse(dgvRuns.Rows[i].Cells[1].Value.ToString());
                    run.RoleID = int.Parse(dgvRuns.Rows[i].Cells[2].Value.ToString());
                    run.Gold = long.Parse(dgvRuns.Rows[i].Cells[5].Value.ToString());

                    runs.Add(run);
                }

                boost.Run = runs;

                db.BoostRepository.InsertBoost(boost);
                db.Save();
                db.Dispose();
                Boostid = boost.BoostID;
                MessageBox.Show("boost Updated");
                this.Close();
            }
        }

        private void txtGoldPot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void chbAutoCompute_CheckedChanged(object sender, EventArgs e)
        {
            ComputeCut();
        }
    }
}
