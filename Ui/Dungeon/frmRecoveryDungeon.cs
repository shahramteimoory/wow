using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fury.Dungeon
{
    public partial class frmRecoveryDungeon : Form
    {
        public frmRecoveryDungeon()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvDeletedDungeon.AutoGenerateColumns = false;
                dgvDeletedDungeon.DataSource = db.DungeonRepository.GetAllSoftDelete();
            }
        }
        private void frmRecoveryDungeon_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void txtFilterDeleted_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtFilterDeleted.Text != "")
                {
                    dgvDeletedDungeon.DataSource = db.DungeonRepository.SearchDeleted(txtFilterDeleted.Text);
                }

                else
                {
                    frmRefresh();
                    db.Dispose();
                }
            }
        }

        private void dgvDeletedDungeon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are u sure Recovery " + dgvDeletedDungeon.Rows[e.RowIndex].Cells[1].Value + "?", "Recovery", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int dungeonid = int.Parse(dgvDeletedDungeon.CurrentRow.Cells["DungeonID"].Value.ToString());
                        db.DungeonRepository.RecoveryDeleteDungeon(dungeonid);
                        db.Save();
                        frmRefresh();
                        db.Dispose();
                        txtFilterDeleted.Text = "";
                        MessageBox.Show("Dungeon Recovered");
                    }
                }
            }
        }
    }
}
