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
                    if (item.IsGold == true)
                    {

                        if (item.Type == (int)TransactionType.Debtor)
                        {
                            dgvTransaction.Rows.Add(item.DateTime.ToString(), item.Title, null, item.Amount, null, null, item.DateTime.Ticks);
                        }
                        else
                        {
                            dgvTransaction.Rows.Add(item.DateTime.ToString(), item.Title, item.Amount, null, null, null, item.DateTime.Ticks);
                        }
                    }
                    else
                    {
                        if (item.Type == (int)TransactionType.Debtor)
                        {
                            dgvTransactionMoney.Rows.Add(item.DateTime.ToString(), item.Title, null, item.Amount, null, null, item.DateTime.Ticks);
                        }
                        else
                        {
                            dgvTransactionMoney.Rows.Add(item.DateTime.ToString(), item.Title, item.Amount, null, null, null, item.DateTime.Ticks);
                        }

                    }

                }
                string method = "Gold";
                var runi = db.RunRepository.GetRunByPlayerID(playerID);
                foreach (var item in runi)
                {
                    if (item.Boost.IsGold == true)
                    {
                        if (item.Boost.Mine)
                        {
                            dgvTransaction.Rows.Add(item.Boost.DateTime.ToString(), $"Dungeon: {item.Boost.Dungeon.Name} Lvl: {item.Boost.Lvl} Adv:{item.Boost.Player.FullName}", null, item.Gold, null, null, item.Boost.DateTime.Ticks);
                            method = "Gold";
                        }
                    }
                    else
                    {
                        dgvTransactionMoney.Rows.Add(item.Boost.DateTime.ToString(), $"Dungeon: {item.Boost.Dungeon.Name} Lvl: {item.Boost.Lvl} Adv:{item.Boost.Player.FullName}", null, item.Gold, null, null, item.Boost.DateTime.Ticks);
                        method = "Money";
                    }

                    dgvRun.Rows.Add(playerID, item.RunID, item.BoostID, item.Role.Title, item.Gold, method, item.Boost.Dungeon.Name, "Detail");
                }

                var myRun = db.RunRepository.GetMyRunByPlayerID(playerID);
                foreach (var item in myRun)
                {
                    if (item.Boost.IsGold==true)
                    {
                        dgvTransaction.Rows.Add(item.Boost.DateTime.ToString(), $"Dungeon: {item.Boost.Dungeon.Name} Lvl: {item.Boost.Lvl} Adv:{item.Boost.Player.FullName}", item.Gold, null, null, null, item.Boost.DateTime.Ticks);
                    }
                    else
                    {
                        dgvTransactionMoney.Rows.Add(item.Boost.DateTime.ToString(), $"Dungeon: {item.Boost.Dungeon.Name} Lvl: {item.Boost.Lvl} Adv:{item.Boost.Player.FullName}", item.Gold, null, null, null, item.Boost.DateTime.Ticks);
                    }

                }


            }
            RefreshDgvTransaction();
            RefreshDgvTransactionMoney();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = playerName;
            frmRefresh();

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
                            long.Parse(dgvTransaction.Rows[i].Cells["cDebtor"].Value.ToString()) * -1;

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

            if (dgvTransaction.Rows.Count != 0)
            {
                long lastBallance = long.Parse(dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].Cells["cBallance"].Value.ToString());
                string lastStatus = dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].Cells["cStatus"].Value.ToString();
                dgvTransaction.Rows.Add(null, "Total", sumCreditor, sumDebtor, lastBallance, lastStatus);

                dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;

                dgvTransaction.FirstDisplayedScrollingRowIndex = dgvTransaction.RowCount - 1;

                lblStatus.Text = "Gold "+lastStatus;
                lblAmount.Text = Math.Abs(lastBallance).ToString("N0");
            }


        }

        private void RefreshDgvTransactionMoney()
        {
            long sumCreditor = 0;
            long sumDebtor = 0;
            dgvTransactionMoney.Sort(dgvTransactionMoney.Columns["cTickM"], System.ComponentModel.ListSortDirection.Ascending);

            for (int i = 0; i < dgvTransactionMoney.Rows.Count; i++)
            {
                if (dgvTransactionMoney.Rows[i].Cells["cDebtorM"].Value == null)
                {
                    //Creditor
                    //ba ballance ++ mishvd

                    sumCreditor += long.Parse(dgvTransactionMoney.Rows[i].Cells["cCreditorM"].Value.ToString());
                    if (i == 0)
                    {
                        dgvTransactionMoney.Rows[i].Cells["cBallanceM"].Value = dgvTransactionMoney.Rows[i].Cells["cCreditorM"].Value;
                        dgvTransactionMoney.Rows[i].Cells["cStatusM"].Value = "cCreditorM";
                    }
                    else
                    {
                        dgvTransactionMoney.Rows[i].Cells["cBallanceM"].Value =
                            long.Parse(dgvTransactionMoney.Rows[i - 1].Cells["cBallanceM"].Value.ToString()) +
                            long.Parse(dgvTransactionMoney.Rows[i].Cells["cCreditorM"].Value.ToString());

                        dgvTransactionMoney.Rows[i].Cells["cStatusM"].Value =
                            GetStatus(long.Parse(dgvTransactionMoney.Rows[i].Cells["cBallanceM"].Value.ToString()));
                    }

                }
                else
                {
                    //Debtor
                    //az ballance -- mishvd

                    sumDebtor += long.Parse(dgvTransactionMoney.Rows[i].Cells["cDebtorM"].Value.ToString());
                    if (i == 0)
                    {
                        dgvTransactionMoney.Rows[i].Cells["cBallanceM"].Value =
                            long.Parse(dgvTransactionMoney.Rows[i].Cells["cDebtorM"].Value.ToString()) * -1;

                        dgvTransactionMoney.Rows[i].Cells["cStatusM"].Value = "DebtorM";
                    }
                    else
                    {
                        dgvTransactionMoney.Rows[i].Cells["cBallanceM"].Value =
                            long.Parse(dgvTransactionMoney.Rows[i - 1].Cells["cBallanceM"].Value.ToString()) -
                            long.Parse(dgvTransactionMoney.Rows[i].Cells["cDebtorM"].Value.ToString());

                        dgvTransactionMoney.Rows[i].Cells["cStatusM"].Value =
                            GetStatus(long.Parse(dgvTransactionMoney.Rows[i].Cells["cBallanceM"].Value.ToString()));
                    }

                }

                if (dgvTransactionMoney.Rows[i].Cells["cStatusM"].Value.ToString() == "CreditorM")
                {
                    dgvTransactionMoney.Rows[i].Cells["cStatusM"].Style.ForeColor = Color.Red;
                }
                if (dgvTransactionMoney.Rows[i].Cells["cStatusM"].Value.ToString() == "CheckoutM")
                {
                    dgvTransactionMoney.Rows[i].Cells["cStatusM"].Style.ForeColor = Color.Green;
                }
            }

            if (dgvTransactionMoney.Rows.Count != 0)
            {
                long lastBallance = long.Parse(dgvTransactionMoney.Rows[dgvTransactionMoney.Rows.Count - 1].Cells["cBallanceM"].Value.ToString());
                string lastStatus = dgvTransactionMoney.Rows[dgvTransactionMoney.Rows.Count - 1].Cells["cStatusM"].Value.ToString();
                dgvTransactionMoney.Rows.Add(null, "Total", sumCreditor, sumDebtor, lastBallance, lastStatus);

                dgvTransactionMoney.Rows[dgvTransactionMoney.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;

                dgvTransactionMoney.FirstDisplayedScrollingRowIndex = dgvTransactionMoney.RowCount - 1;

                lblStatusMoney.Text = "Money "+lastStatus;
                lblAmountMoney.Text = Math.Abs(lastBallance).ToString("N0");
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

