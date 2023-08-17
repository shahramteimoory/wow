using DataLayer.Context;
using System;
using System.IO;
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
        public TransactionType type;
        void frmRefresh()
        {
            if (type == TransactionType.Creditor)
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
                string Imagename = Guid.NewGuid().ToString() + Path.GetExtension(pcTransaction.ImageLocation);
                string paath = Application.StartupPath + "Images";
                if (!Directory.Exists(paath))
                {
                    Directory.CreateDirectory(paath);
                }
                pcTransaction.Image.Save(Path.Combine(paath , Imagename));
                using (UnitOfWork db = new UnitOfWork())
                {
                    DataLayer.Transaction transaction = new DataLayer.Transaction()
                    {
                        DateTime = DateTime.Now,
                        Image = Imagename,
                        Amount = long.Parse(txtAmount.Text),
                        PlayerID = playerID,
                        Type = (int)type,
                        Title = txtTitle.Text,

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
    }
}
