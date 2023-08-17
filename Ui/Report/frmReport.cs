using DataLayer.Context;
using System;
using System.Drawing;
using System.Windows.Forms;
using Ui.Boost;
using Ui.Transaction;
using static Utility.Enum.Enums;

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
                
                foreach (var item in trans)
                {

                    if (item.Type == (int)TransactionType.Debtor)
                    {
                        dgvTransaction.Rows.Add(item.DateTime.ToString() , item.Title , null , item.Amount , null , null , item.DateTime.Ticks);
                    }
                    else
                    {
                        dgvTransaction.Rows.Add(item.DateTime.ToString(), item.Title, item.Amount, null, null, null , item.DateTime.Ticks);
                    }
                    
                }
               
                var runi = db.RunRepository.GetRunByPlayerID(playerID);
                foreach (var item in runi)
                {
                    if (item.Boost.Mine)
                    {
                        dgvTransaction.Rows.Add(item.Boost.DateTime.ToString(), $"Dungeon: {item.Boost.Dungeon.Name} Lvl: {item.Boost.Lvl} Adv:{item.Boost.Player.FullName}", null, item.Gold, null, null ,item.Boost.DateTime.Ticks);
                    }

                    dgvRun.Rows.Add(playerID, item.RunID, item.BoostID, item.Role.Title, item.Gold, item.Boost.Dungeon.Name);
                }

                var myRun = db.RunRepository.GetMyRunByPlayerID(playerID);
                foreach (var item in myRun)
                {
                    
                    dgvTransaction.Rows.Add(item.Boost.DateTime.ToString(),$"Dungeon: {item.Boost.Dungeon.Name} Lvl: {item.Boost.Lvl} Adv:{item.Boost.Player.FullName}" , item.Gold, null , null, null, item.Boost.DateTime.Ticks);
                    
                }


            }
            RefreshDgvTransaction();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = playerName;
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

        
        private void RefreshDgvTransaction()
        {
            long sumCreditor = 0;
            long sumDebtor = 0;
            dgvTransaction.Sort(dgvTransaction.Columns["cTick"], System.ComponentModel.ListSortDirection.Ascending);

            for (int i = 0; i < dgvTransaction.Rows.Count; i++) 
            {
                if (dgvTransaction.Rows[i].Cells["cDebtor"].Value == null)
                {
                    //Creditor
                    //ba ballance ++ mishvd

                    sumCreditor += long.Parse(dgvTransaction.Rows[i].Cells["cCreditor"].Value.ToString());
                    if (i == 0)
                    {
                        dgvTransaction.Rows[i].Cells["cBallance"].Value = dgvTransaction.Rows[i].Cells["cCreditor"].Value;
                        dgvTransaction.Rows[i].Cells["cStatus"].Value = "Creditor";
                    }
                    else
                    {
                        dgvTransaction.Rows[i].Cells["cBallance"].Value = 
                            long.Parse(dgvTransaction.Rows[i - 1].Cells["cBallance"].Value.ToString()) + 
                            long.Parse(dgvTransaction.Rows[i].Cells["cCreditor"].Value.ToString());

                        dgvTransaction.Rows[i].Cells["cStatus"].Value =
                            GetStatus(long.Parse(dgvTransaction.Rows[i].Cells["cBallance"].Value.ToString()));
                    }

                }
                else
                {
                    //Debtor
                    //az ballance -- mishvd

                    sumDebtor += long.Parse(dgvTransaction.Rows[i].Cells["cDebtor"].Value.ToString());
                    if (i == 0)
                    {
                        dgvTransaction.Rows[i].Cells["cBallance"].Value = 
                            long.Parse( dgvTransaction.Rows[i].Cells["cDebtor"].Value.ToString()) * -1;

                        dgvTransaction.Rows[i].Cells["cStatus"].Value = "Debtor";
                    }
                    else
                    {
                        dgvTransaction.Rows[i].Cells["cBallance"].Value =
                            long.Parse(dgvTransaction.Rows[i - 1].Cells["cBallance"].Value.ToString()) -
                            long.Parse(dgvTransaction.Rows[i].Cells["cDebtor"].Value.ToString());

                        dgvTransaction.Rows[i].Cells["cStatus"].Value =
                            GetStatus(long.Parse(dgvTransaction.Rows[i].Cells["cBallance"].Value.ToString()));
                    }

                }

                if (dgvTransaction.Rows[i].Cells["cStatus"].Value.ToString() == "Creditor")
                {
                    dgvTransaction.Rows[i].Cells["cStatus"].Style.ForeColor = Color.Red;
                }
                if (dgvTransaction.Rows[i].Cells["cStatus"].Value.ToString() == "Checkout")
                {
                    dgvTransaction.Rows[i].Cells["cStatus"].Style.ForeColor = Color.Green;
                }
            }

            if (dgvTransaction.Rows.Count !=0)
            {
                long lastBallance = long.Parse(dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].Cells["cBallance"].Value.ToString());
                string lastStatus = dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].Cells["cStatus"].Value.ToString();
                dgvTransaction.Rows.Add(null, "Total", sumCreditor, sumDebtor, lastBallance, lastStatus);

                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;

                dgvTransaction.FirstDisplayedScrollingRowIndex = dgvTransaction.RowCount - 1;

                lblStatus.Text = lastStatus;
                lblAmount.Text = Math.Abs(lastBallance).ToString("N0");
            }

            
        }


        private string GetStatus(long Ballnace)
        {
            if (Ballnace == 0)
            {
                return "Checkout";
            }
            else if (Ballnace > 1) 
            {
                return "Creditor";
            }
            else
            {
                return "Debtor";
            }
            
        }
    }
}

