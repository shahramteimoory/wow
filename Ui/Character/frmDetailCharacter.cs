using DataLayer.Context;
using Newtonsoft.Json;
using RaiderIo.RecentRuns;
using RaiderIo.RunDetail;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace Fury.Character
{
    public partial class frmDetailCharacter : Form
    {
        public frmDetailCharacter()
        {
            InitializeComponent();
        }
        public string region;
        public string name;
        public string realm;
       void frmrefresh()
        {
            using(UnitOfWork db= new UnitOfWork())
            {
                var boost=db.BoostRepository.NotAsignedBoosts();
                foreach (var item in boost)
                {
                    dgvboost.Rows.Add(item.BoostID, "Sign", item.Player.FullName, item.Dungeon.Name, item.Lvl, item.Gold);
                }
            }
        }
        private async void frmDetailCharacter_Load(object sender, EventArgs e)
        {
            frmrefresh();
            string url = $"https://raider.io/api/v1/characters/profile?region={region.ToLower()}&realm={realm}&name={name}&fields=mythic_plus_recent_runs";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    RaiderIo.RecentRuns.RecentRuns characterInfo = JsonConvert.DeserializeObject<RecentRuns>(content);
                    pcCharacter.ImageLocation = characterInfo.thumbnail_url;
                    lblName.Text = characterInfo.name;
                    lblRace.Text = characterInfo.race;
                    lblClass.Text = characterInfo.@class;
                    lblActiveSpec.Text = characterInfo.active_spec_name;
                    lblRole.Text = characterInfo.active_spec_role;
                    lblGender.Text = characterInfo.gender;
                    lblRealm.Text = characterInfo.realm;
                    lblAchievement.Text = characterInfo.achievement_points.ToString();
                    if (characterInfo.faction == "horde")
                    {
                        lblFaction.ForeColor = Color.Red;
                        lblFaction.Text = "Horde";
                    }
                    else
                    {
                        lblFaction.ForeColor = Color.Blue;
                        lblFaction.Text = "Alliance";
                    }
                    lblRaiderIo.Tag = characterInfo.profile_url;
                    foreach (var item in characterInfo.mythic_plus_recent_runs)
                    {
                        dgvRecentRuns.Rows.Add("Select", item.dungeon, item.mythic_level, item.num_keystone_upgrades, item.completed_at, item.score, item.url, "link");
                    }
                }
                else
                {
                    MessageBox.Show("Bad Request");
                    this.Close();
                }
            }
        }

        private void lblRaiderIo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblRaiderIo.Tag != null)
            {
                string url = lblRaiderIo.Tag.ToString();
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Character link" + ex.Message);
                }
            }
        }

        private async void dgvRecentRuns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string url = dgvRecentRuns.CurrentRow.Cells[6].Value.ToString();
            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    Process.Start(url);
                }
                else
                {
                    MessageBox.Show("Invalid URL");
                }
            }
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string[] parts = url.Split('/');
                string season = parts[4];
                string runId = parts[5].Split('-')[0];
                string urlrun = $"https://raider.io/api/v1/mythic-plus/run-details?season={season}&id={runId}";
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(urlrun);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        RaiderIo.RunDetail.RunDetail rundetail = JsonConvert.DeserializeObject<RunDetail>(content);
                        lblDungeonName.Text=rundetail.dungeon.name;
                        lblSeason.Text=rundetail.dungeon.patch;
                        lblTimeremining.Text = $"{(rundetail.time_remaining_ms/ 60000).ToString()} Minutes left";
                        lblDungeonlvl.Text=$"Level: {rundetail.mythic_level.ToString()}";
                        lblUpgrade.Text=$"+{rundetail.num_chests.ToString()}";
                        lblAffix1.Text = rundetail.weekly_modifiers[0].name;
                        lblAffix2.Text= rundetail.weekly_modifiers[1].name;
                        lblAffix3.Text = rundetail.weekly_modifiers[2].name;
                        //دیتیل هر کدوم از پلیرا
                        lblRole1.Text = $"{rundetail.roster[0].role.ToUpper()} :";
                        lblPlayer1.Text= rundetail.roster[0].character.name;
                        lblPlayer1.Tag = rundetail.roster[0].character.path;
                        lblilvl1.Text = rundetail.roster[0].items.item_level_equipped.ToString();
                        lblScore1.Text = rundetail.roster[0].ranks.score.ToString();

                        lblRole2.Text = $"{rundetail.roster[1].role.ToUpper()} :";
                        lblPlayer2.Text = rundetail.roster[1].character.name;
                        lblPlayer2.Tag = rundetail.roster[1].character.path;
                        lblilvl2.Text = rundetail.roster[1].items.item_level_equipped.ToString();
                        lblScore2.Text = rundetail.roster[1].ranks.score.ToString();

                        lblRole3.Text = $"{rundetail.roster[2].role.ToUpper()} :";
                        lblPlayer3.Text = rundetail.roster[2].character.name;
                        lblPlayer3.Tag = rundetail.roster[2].character.path;
                        lblilvl3.Text = rundetail.roster[2].items.item_level_equipped.ToString();
                        lblScore3.Text = rundetail.roster[2].ranks.score.ToString();

                        lblRole4.Text = $"{rundetail.roster[3].role.ToUpper()} :";
                        lblPlayer4.Text = rundetail.roster[3].character.name;
                        lblPlayer4.Tag = rundetail.roster[3].character.path;
                        lblilvl4.Text = rundetail.roster[3].items.item_level_equipped.ToString();
                        lblScore4.Text = rundetail.roster[3].ranks.score.ToString();

                        lblRole5.Text = $"{rundetail.roster[4].role.ToUpper()} :";
                        lblPlayer5.Text = rundetail.roster[4].character.name;
                        lblPlayer5.Tag = rundetail.roster[4].character.path;
                        lblilvl5.Text = rundetail.roster[4].items.item_level_equipped.ToString();
                        lblScore5.Text = rundetail.roster[4].ranks.score.ToString();

                        lblseasondetail.Text = rundetail.season;
                    }
                }
            }

        }

        private void lblPlayer1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPlayer1.Tag != null)
            {
                string url = $"https://raider.io{lblPlayer1.Tag.ToString()}";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Character link" + ex.Message);
                }
            }
        }

        private void lblPlayer2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPlayer2.Tag != null)
            {
                string url = $"https://raider.io{lblPlayer2.Tag.ToString()}";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Character link" + ex.Message);
                }
            }
        }

        private void lblPlayer3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPlayer3.Tag != null)
            {
                string url = $"https://raider.io{lblPlayer3.Tag.ToString()}";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Character link" + ex.Message);
                }
            }
        }

        private void lblPlayer4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPlayer4.Tag != null)
            {
                string url = $"https://raider.io{lblPlayer4.Tag.ToString()}";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Character link" + ex.Message);
                }
            }
        }

        private void lblPlayer5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblPlayer5.Tag != null)
            {
                string url = $"https://raider.io{lblPlayer5.Tag.ToString()}";
                try
                {
                    Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Character link" + ex.Message);
                }
            }
        }
    }
}


