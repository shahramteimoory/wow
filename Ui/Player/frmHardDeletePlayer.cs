using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Fury.Player
{
    public partial class frmHardDeletePlayer : Form
    {
        public frmHardDeletePlayer()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayerHardDelete.AutoGenerateColumns = false;
                dgvPlayerHardDelete.DataSource = db.PlayerRepository.GetAllSoftDelete();
            }
        }
        private void frmHardDeletePlayer_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void dgvPlayerHardDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are u sure for Hard Remove " + dgvPlayerHardDelete.Rows[e.RowIndex].Cells[1].Value + "?", "Hard Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int playerid = int.Parse(dgvPlayerHardDelete.CurrentRow.Cells["PlayerID"].Value.ToString());
                        db.PlayerRepository.HardDeletePlayer(playerid);
                        db.Save();
                        frmRefresh();
                        db.Dispose();
                        txtPlayerFilter.Text = "";
                        MessageBox.Show("Player Hard Deleted");
                    }
                }
            }
        }

        private void txtPlayerFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtPlayerFilter.Text != "")
                {
                    dgvPlayerHardDelete.DataSource = db.PlayerRepository.SearchDeleted(txtPlayerFilter.Text);
                }

                else
                {
                    frmRefresh();
                    db.Dispose();
                }
            }
        }
    }
}