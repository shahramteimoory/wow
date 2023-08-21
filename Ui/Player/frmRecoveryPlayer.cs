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

namespace Fury.Player
{
    public partial class frmRecoveryPlayer : Form
    {
        public frmRecoveryPlayer()
        {
            InitializeComponent();
        }
        void frmrefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvRecoveryPlayer.AutoGenerateColumns = false;
                dgvRecoveryPlayer.DataSource = db.PlayerRepository.GetAllSoftDelete();
            }
        }
        private void frmRecoveryPlayer_Load(object sender, EventArgs e)
        {
            frmrefresh();
        }

        private void dgvRecoveryPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are u sure for Recovery " + dgvRecoveryPlayer.Rows[e.RowIndex].Cells[1].Value + "?", "Recovery", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int playerid = int.Parse(dgvRecoveryPlayer.CurrentRow.Cells["PlayerID"].Value.ToString());
                        db.PlayerRepository.RecoveryDeletePlayer(playerid);
                        db.Save();
                        frmrefresh();
                        db.Dispose();
                        txtPlayerFilter.Text = "";
                        MessageBox.Show("Player Recovered");
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
                    dgvRecoveryPlayer.DataSource = db.PlayerRepository.SearchDeleted(txtPlayerFilter.Text);
                }

                else
                {
                    frmrefresh();
                    db.Dispose();
                }
            }
        }
    }
}
