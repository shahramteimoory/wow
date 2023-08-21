using DataLayer.Context;
using Fury.Dungeon;
using System;
using System.Windows.Forms;
using ValidationComponents;

namespace Ui.Dungeon
{
    public partial class frmDungeonManger : Form
    {
        public frmDungeonManger()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvDungeons.AutoGenerateColumns = false;
                dgvDungeons.DataSource = db.DungeonRepository.GetAllDungeon();
                db.Dispose();
            }
        }
        private void btnInsertDungeon_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int count = db.DungeonRepository.GetCount(txtInsertDungeon.Text);
                    if (count > 0)
                    {
                        MessageBox.Show("Dungeon Already Excist");
                        return;
                    }
                    else
                    {
                        DataLayer.Dungeon dungeon = new DataLayer.Dungeon()
                        {
                            Name = txtInsertDungeon.Text,
                            IsDelete = false,
                        };
                        db.DungeonRepository.InsertDungeon(dungeon);
                        db.Save();
                        txtInsertDungeon.Text = "";
                    }
                    frmRefresh();
                    db.Dispose();
                }
            }
        }

        private void frmDungeonManger_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvDungeons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                //delete
                DialogResult dialogResult = MessageBox.Show("Are u sure for Soft Remove " + dgvDungeons.Rows[e.RowIndex].Cells[1].Value + "?", "Soft Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int dungeonid = int.Parse(dgvDungeons.CurrentRow.Cells["DungeonID"].Value.ToString());
                        db.DungeonRepository.SoftDeleteDungeon(dungeonid);
                        db.Save();
                        frmRefresh();
                        db.Dispose();
                        txtSearch.Text = "";
                        MessageBox.Show("Dungeon Soft Deleted");
                    }
                }
            }
            //Edit
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                frmEditDungeon frmEditdungeon = new frmEditDungeon();
                frmEditdungeon.txtEdit.Text = dgvDungeons.Rows[e.RowIndex].Cells["DungeonName"].Value.ToString();
                DialogResult dialogResult = frmEditdungeon.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    if (frmEditdungeon.txtEdit.Text != "")
                    {
                        int dungeonid = int.Parse(dgvDungeons.CurrentRow.Cells["DungeonID"].Value.ToString());
                        string dungeonName = frmEditdungeon.txtEdit.Text;

                        using (UnitOfWork db = new UnitOfWork())
                        {
                            DataLayer.Dungeon dungeon = new DataLayer.Dungeon()
                            {
                                DungeonID = dungeonid,
                                Name = dungeonName,
                                IsDelete = false,
                            };
                            db.DungeonRepository.UpdateDungeon(dungeon);
                            db.Save();
                            frmRefresh();
                            db.Dispose();
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtSearch.Text != "")
                {
                    dgvDungeons.DataSource = db.DungeonRepository.Search(txtSearch.Text);
                }

                else
                {
                    frmRefresh();
                    db.Dispose();
                }
            }
        }

        private void btnHardDeleteDungeon_Click(object sender, EventArgs e)
        {
            frmHardDeleteDungeon frmHardDeleteDungeon = new frmHardDeleteDungeon();
            frmHardDeleteDungeon.ShowDialog();
            frmRefresh();
        }

        private void btnRecoveryDungeon_Click(object sender, EventArgs e)
        {
            frmRecoveryDungeon frmRecoveryDungeon = new frmRecoveryDungeon();
            frmRecoveryDungeon.ShowDialog();
            frmRefresh();
        }
    }
}
