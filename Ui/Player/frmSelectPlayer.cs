using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Ui.Player
{
    public partial class frmSelectPlayer : Form
    {
        public frmSelectPlayer()
        {
            InitializeComponent();
        }

        private void SelectPlayer_Load(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayer.AutoGenerateColumns = false;
                dgvPlayer.DataSource = db.PlayerRepository.GetAllPlayer();

            }
        }

        private void txtPlayerNameFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayer.DataSource = db.PlayerRepository.Search(txtPlayerNameFilter.Text);
            }
        }


        private void dgvPlayer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lblID.Text = dgvPlayer.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblName.Text = dgvPlayer.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
