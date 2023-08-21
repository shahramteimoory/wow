using DataLayer.Context;
using System;
using System.Windows.Forms;
using static Utility.Enum.Enums;

namespace Ui.Transaction
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPlayerList.AutoGenerateColumns = false;
                dgvPlayerList.DataSource = db.PlayerRepository.GetAllPlayersExceptOwner();
                
            }





        }
        private void frmTransaction_Load(object sender, EventArgs e)
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
                frmTransactionDetail frmTransactionDetail = new frmTransactionDetail();
                frmTransactionDetail.playerID = playerid;
                frmTransactionDetail.ShowDialog();



            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FrmPayOrReciveTransaction frm = new FrmPayOrReciveTransaction();
            frm.transactionType = TransactionType.Creditor;
            frm.playerID = int.Parse(dgvPlayerList.CurrentRow.Cells["Column1"].Value.ToString());
            frm.ShowDialog();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            FrmPayOrReciveTransaction frm = new FrmPayOrReciveTransaction();
            frm.transactionType = TransactionType.Debtor;
            frm.playerID = int.Parse(dgvPlayerList.CurrentRow.Cells["Column1"].Value.ToString());
            frm.ShowDialog();
        }
    }
}