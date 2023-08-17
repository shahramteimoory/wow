using DataLayer.Context;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ui.Transaction
{
    public partial class frmTransactionDetail : Form
    {
        public int playerID;

        public frmTransactionDetail()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                var trans = db.TransactionRepository.GetTransactionByPlayerID(playerID);
                string player = db.PlayerRepository.GetPlayerNameById(playerID);
                string type;
                foreach (var item in trans)
                {
                    if (item.Type == 0)
                    {
                        type = "Debtor";
                    }
                    else
                    {
                        type = "Creditor";
                    }
                    dgvTransactionDetail.Rows.Add(item.TransactionID, player, item.Amount, type, item.DateTime, item.Title, item.Image);

                }

                dgvTransactionDetail.Sort(dgvTransactionDetail.Columns["Column5"], ListSortDirection.Descending);

            }
        }

        private void frmTransactionDetail_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }
        public void Dgv()
        {

        }
        public void dgvTransactionDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            TxtTitle.Text = dgvTransactionDetail.CurrentRow.Cells[5].Value.ToString();
            string image = dgvTransactionDetail.CurrentRow.Cells[6].Value.ToString();
            pcTransactionDetail.ImageLocation = Application.StartupPath + "/Images/" + image;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
