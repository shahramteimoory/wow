using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Ui
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnOwnerChange_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DataLayer.Player owner = new DataLayer.Player()
                {
                    PlayerID = 0,
                    FullName = txtOwnerChange.Text,
                    IsDelete = false,
                };
                db.PlayerRepository.UpdatePlayer(owner);
                db.Save();
                this.Close();
            }
        }
    }
}
