using DataLayer;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;


namespace Ui.Transaction
{
    public partial class frmEditTransaction : Form
    {
        public frmEditTransaction()
        {
            InitializeComponent();
        }
        public int transactionID;
        
        
        void frmRefresh()
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                DataLayer.Transaction transaction = new DataLayer.Transaction();
                transaction.TransactionID = transactionID;
                transaction = db.TransactionRepository.GetTransactionByTransactionID(transaction.TransactionID);
                txtAmount.Text = transaction.Amount.ToString();
                txtTitle.Text = transaction.Title.ToString();
                txtImageURL.Text = transaction.Image.ToString();
                lblPlayerName.Text = transaction.Player.FullName;
                pcTransaction.ImageLocation = transaction.Image;
                if (transaction.Type == 1)
                {
                    this.Text = "Payment";
                    lblFrmType.Text = "The payment";
                }
                else
                {
                    this.Text = "Receive";
                    lblFrmType.Text = "Receiving";
                }
                
            }
        }
        private void frmEditTransaction_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void btnUploadFrpmPC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcTransaction.ImageLocation = ofd.FileNames[0];
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void rbFromPC_CheckedChanged(object sender, EventArgs e)
        {
            btnUploadFrpmPC.Enabled = rbFromPC.Checked;
        }

        private void rbFromURL_CheckedChanged(object sender, EventArgs e)
        {
            txtImageURL.Enabled = rbFromURL.Checked;
        }

        private void txtImageURL_Leave(object sender, EventArgs e)
        {
            try
            {
                pcTransaction.ImageLocation = txtImageURL.Text;
            }
            catch
            {
                MessageBox.Show("URL not found");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    string paath = Application.StartupPath + "\\Images\\";
                    if (!Directory.Exists(paath))
                    {
                        Directory.CreateDirectory(paath);
                    }
                    string Imagename;
                    if (rbFromPC.Checked)
                    {
                        if (pcTransaction.ImageLocation != null)
                        {
                            Imagename = paath + Guid.NewGuid().ToString() + Path.GetExtension(pcTransaction.ImageLocation);
                            pcTransaction.Image.Save(Path.Combine(Imagename));
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("You did not uplode photo.\n Are you sure for Continue?", "Uoload photo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                            Imagename = "DefaultTransaction.jpg";
                        }
                    }
                    else
                    {
                        Imagename = txtImageURL.Text;
                    }
                    int type;
                    if (lblFrmType.Text == "The payment")
                    {
                        type = 1;
                    }
                    else
                    {
                        type = 0;
                    }

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        DataLayer.Transaction transactions = db.TransactionRepository.GetTransactionByTransactionID(transactionID);


                        transactions.Image = Imagename;
                        transactions.Amount = long.Parse(txtAmount.Text);
                        transactions.PlayerID = db.PlayerRepository.GetPlayerIdByName(lblPlayerName.Text);
                        transactions.Type = type;
                        transactions.Title = txtTitle.Text;

                        db.TransactionRepository.UpdateTransaction(transactions);
                        db.Save();
                        Dispose();
                        this.Close();

                    }

                }
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessage = "خطا در اعتبارسنجی موجودیت: \n";
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += "ویژگی: " + validationError.PropertyName + "\nخطا: " + validationError.ErrorMessage + "\n";
                    }
                }

                MessageBox.Show(errorMessage);
                // انجام اقدامات مورد نیاز برای رفع خطاها، مانند نمایش پیغام به کاربر یا ثبت آن در یک فایل لاگ
            }
        }
    }
}