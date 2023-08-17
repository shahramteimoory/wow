using DataLayer.Context;
using System;
using System.Windows.Forms;
using Ui.Boost;
using Ui.Player;
using Ui.Report;
using Ui.Transaction;

namespace Ui
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPlayerManger frmPlayerManger = new frmPlayerManger();
            frmPlayerManger.ShowDialog();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            lblVersion.Text = "Version : " + fvi.FileVersion;
            lblDateShamsi.Text = Utility.Convertor.DateConvertor.toshamsi(DateTime.Now);
            using (UnitOfWork db = new UnitOfWork())
            {
                var o1 = db.PlayerRepository.GetPlayerById(0);
                if (o1.IsDelete == true || o1.FullName == "")
                {
                    frmSetting setting = new frmSetting();
                    setting.ShowDialog();

                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnDungeon_Click(object sender, EventArgs e)
        {
            Ui.Dungeon.frmDungeonManger frmDungeon = new Dungeon.frmDungeonManger();
            frmDungeon.ShowDialog();
        }

        private void btnBoost_Click(object sender, EventArgs e)
        {
            frmBoostManger frmBoost = new frmBoostManger();
            frmBoost.ShowDialog();
        }

        private void btnBoostSetting_Click(object sender, EventArgs e)
        {
            frmBoostSetting frmBoostSetting = new frmBoostSetting();
            frmBoostSetting.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmTransaction frmTransaction = new frmTransaction();
            frmTransaction.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmPlayerReport frmPlayerReport = new frmPlayerReport();
            frmPlayerReport.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void cbxReset_CheckedChanged(object sender, EventArgs e)
        {
            btnResetAllDate.Visible = true;
        }

        private void btnResetAllDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your PC will exlode in 30 secound");
        }
    }
}
