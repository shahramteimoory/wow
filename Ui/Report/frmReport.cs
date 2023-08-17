using DataLayer.Context;
using System;
using System.Windows.Forms;
using Ui.Boost;
using Ui.Transaction;

namespace Ui.Report
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        public int playerID;
        public string playerName;

        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var trans = db.TransactionRepository.GetTransactionByPlayerID(playerID);
                string type;
                double bedehkartotal = 0;
                double talabkartotal = 0;
                foreach (var item in trans)
                {

                    if (item.Type == 0)
                    {

                        bedehkartotal += item.Amount;
                    }
                    else
                    {

                        talabkartotal += item.Amount;
                    }
                    if (item.Type == 0)
                    {
                        type = "Debtor";
                    }
                    else
                    {
                        type = "Creditor";
                    }


                    dgvTransaction.Rows.Add(playerID, item.TransactionID, type, item.Amount, item.DateTime, item.Title);
                }
                if (bedehkartotal > talabkartotal)
                {
                    lblType.Text = "Creditor";
                }
                else
                {
                    lblType.Text = "Debtor";
                }
                double result = 0;
                result = bedehkartotal - talabkartotal;
                lblAmount.Text = result.ToString();
                var runi = db.RunRepository.GetRunByPlayerID(playerID);
                foreach (var item in runi)
                {

                    dgvRun.Rows.Add(playerID, item.RunID, item.BoostID, item.Role.Title, item.Gold, item.Boost.Dungeon.Name);
                }
            }
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            lblPlayer2.Text = playerName;
            frmRefresh();

        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                frmTransactionDetail frmTransactionDetail = new frmTransactionDetail();
                frmTransactionDetail.playerID = playerID;
                frmTransactionDetail.ShowDialog();



            }
        }

        private void dgvRun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                int boostid = int.Parse(dgvRun.CurrentRow.Cells[2].Value.ToString());
                frmBoostDetail frmBoostDetail = new frmBoostDetail();
                frmBoostDetail.Boostid = boostid;
                frmBoostDetail.ShowDialog();

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

