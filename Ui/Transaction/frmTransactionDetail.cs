using DataLayer.Context;
using Fury;
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
                string method;
                dgvTransactionDetail.Rows.Clear();
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
                    if (item.IsGold==true)
                    {
                        method = "Gold";
                    }
                    else
                    {
                        method = "Money";
                    }

                    dgvTransactionDetail.Rows.Add(item.TransactionID, player, item.Amount, type, method, item.DateTime, item.Title, item.Image);

                }

                dgvTransactionDetail.Sort(dgvTransactionDetail.Columns["Column5"], ListSortDirection.Descending);

                dgvTransactionDetail.Refresh(); // رفرش رابط کاربری فرم
                
            }
        }

        private void frmTransactionDetail_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        public void dgvTransactionDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            TxtTitle.Text = dgvTransactionDetail.CurrentRow.Cells[5].Value.ToString();
            string image = dgvTransactionDetail.CurrentRow.Cells[6].Value.ToString();
            pcTransactionDetail.ImageLocation = image;
            lblLink.Text = image;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(lblLink.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("404 not found");
                FileLogger.Log(ex.ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransactionDetail.CurrentRow != null)
                {
                    int transactionid = int.Parse(dgvTransactionDetail.CurrentRow.Cells["Column1"].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (DialogResult.Yes== MessageBox.Show("You sure about Delete this Transaction", "Warning", MessageBoxButtons.YesNo))
                        {
                            db.TransactionRepository.DeleteTransaction(transactionid);
                            db.Save();
                            db.Dispose();
                            frmRefresh();
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(ex.ToString());
                MessageBox.Show("Please Select Transaction for Delete");
            }
 


                
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTransactionDetail.CurrentRow != null)
            {
                int transactionid = int.Parse(dgvTransactionDetail.CurrentRow.Cells["Column1"].Value.ToString());
                using (UnitOfWork db = new UnitOfWork())
                {
                 
                    frmEditTransaction frmEditTransaction = new frmEditTransaction();
                    
                    frmEditTransaction.transactionID = transactionid;
                    frmEditTransaction.ShowDialog();
                    frmRefresh();
                    
                }
            }
        }
    }
}
