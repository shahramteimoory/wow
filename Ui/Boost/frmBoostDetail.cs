using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Ui.Boost
{
    public partial class frmBoostDetail : Form
    {
        public int Boostid;
        public frmBoostDetail()
        {
            InitializeComponent();
        }
        void frmRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                var boost = db.BoostRepository.GetBoostById(Boostid);
                lblPot.Text = $"Pot Gold:{boost.Gold.ToString()}";
                lblLvl.Text = $"Dungeon Level: {boost.Lvl.ToString()}";
                LblDungeonName.Text = $"Dungeon Name :{boost.Dungeon.Name}";

                lblAdvID.Text = boost.PlayerID.ToString();
                lblAdvName.Text = $"Advertiser: {boost.Player.FullName}";
                lblDataTime.Text = boost.DateTime.ToShortDateString();

                var run = boost.Run;
                dgvRuns.Rows.Clear();
                foreach (var item in run)
                {
                    dgvRuns.Rows.Add(item.RunID, item.PlayerID, item.RoleID, item.Player.FullName, item.Role.Title, item.Gold);
                }
                db.Dispose();

            }
        }

        private void frmBoostDetail_Load(object sender, EventArgs e)
        {

            frmRefresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



