﻿using Newtonsoft.Json;
using RaiderIo.RecentRuns;
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
        private async void frmDetailCharacter_Load(object sender, EventArgs e)
        {
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
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {

                    }
                }
            }

        }
    }
}

