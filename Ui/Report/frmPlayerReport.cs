using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Ui.Report
{
    public partial class frmPlayerReport : Form
    {
        public frmPlayerReport()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayerList.AutoGenerateColumns = false;
                dgvPlayerList.DataSource = db.PlayerRepository.GetAllPlayersExceptOwner();
                db.Dispose();
            }
        }
        private void frmPlayerReport_Load(object sender, EventArgs e)
        {
            frmRefresh();

        }

        private void txtPlayerFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtPlayerFilter.Text != "")
                {
                    dgvPlayerList.DataSource = db.PlayerRepository.Search(txtPlayerFilter.Text);
                }

                else
                {
                    frmRefresh();
                    db.Dispose();
                }
            }
        }

        private void dgvPlayerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                int playerid = int.Parse(dgvPlayerList.CurrentRow.Cells["Column1"].Value.ToString());
                string playername = (dgvPlayerList.CurrentRow.Cells["Column2"].Value.ToString());
                frmReport frmPlayerReport = new frmReport();
                frmPlayerReport.playerID = playerid;
                frmPlayerReport.playerName = playername;
                frmPlayerReport.ShowDialog();
            }
        }
    }
}
