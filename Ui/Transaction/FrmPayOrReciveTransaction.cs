using DataLayer.Context;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using ValidationComponents;
using static Utility.Enum.Enums;

namespace Ui.Transaction
{
    public partial class FrmPayOrReciveTransaction : Form
    {
        public FrmPayOrReciveTransaction()
        {
            InitializeComponent();
        }
        public int playerID;
        public TransactionType transactionType;
        void frmRefresh()
        {
            if (transactionType == TransactionType.Creditor)
            {
                this.Text = "Payment";
                lblFrmType.Text = "the payment";
            }
            else
            {
                this.Text = "Receive";
                lblFrmType.Text = "Receiving";
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                string playername = db.PlayerRepository.GetPlayerNameById(playerID);
                lblPlayerName.Text = playername;
            }
        }
        private void FrmPayOrReciveTransaction_Load(object sender, EventArgs e)
        {
            frmRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcTransaction.ImageLocation = ofd.FileNames[0];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                

                
                
                
                using (UnitOfWork db = new UnitOfWork())
                {
                    DataLayer.Transaction transaction = new DataLayer.Transaction()
                    {
                        DateTime = DateTime.Now,
                        Image = Imagename,
                        Amount = long.Parse(txtAmount.Text),
                        PlayerID = playerID,
                        Type = (int)transactionType,
                        Title = $"{lblFrmType.Text}: Title: {txtTitle.Text}",

                    };
                    db.TransactionRepository.InsertTransaction(transaction);
                    db.Save();
                    this.Close();
                }

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
    }
}
