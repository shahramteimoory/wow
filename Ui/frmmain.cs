using DataLayer.Context;
using Fury;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        private async Task WowTokePrice()
        {

            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("x-access-token", "goldapi-4tcfrlkvea6mk-io");
                var response = await httpClient.GetAsync("https://www.goldapi.io/api/XAU/USD");
                var responseBody = await response.Content.ReadAsStringAsync();

                var json = JObject.Parse(responseBody);
                var price = json["price"];

                lblWowTokenPrice.Text = ($"EU token: {price} Gold");

            }
            catch (Exception ex)
            {
                FileLogger.Log(ex.ToString());
                lblWowTokenPrice.Text = ("خطا در دریافت قیمت طلا: " + ex.Message);
            }


        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            _ = WowTokePrice();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            lblVersion.Text = "Version : " + fvi.FileVersion;

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

        private void chengToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBoostList_Click(object sender, EventArgs e)
        {
            frmBoostSetting frmBoostSetting = new frmBoostSetting();
            frmBoostSetting.ShowDialog();
        }
    }
}
