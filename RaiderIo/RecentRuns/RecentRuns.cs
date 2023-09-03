using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiderIo.RecentRuns
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Affix
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public string wowhead_url { get; set; }
    }

    public class MythicPlusRecentRun
    {
        public string dungeon { get; set; }
        public string short_name { get; set; }
        public int mythic_level { get; set; }
        public DateTime completed_at { get; set; }
        public int clear_time_ms { get; set; }
        public int par_time_ms { get; set; }
        public int num_keystone_upgrades { get; set; }
        public int map_challenge_mode_id { get; set; }
        public int zone_id { get; set; }
        public double score { get; set; }
        public List<Affix> affixes { get; set; }
        public string url { get; set; }
    }

    public class RecentRuns
    {
        public string name { get; set; }
        public string race { get; set; }
        public string @class { get; set; }
        public string active_spec_name { get; set; }
        public string active_spec_role { get; set; }
        public string gender { get; set; }
        public string faction { get; set; }
        public int achievement_points { get; set; }
        public int honorable_kills { get; set; }
        public string thumbnail_url { get; set; }
        public string region { get; set; }
        public string realm { get; set; }
        public DateTime last_crawled_at { get; set; }
        public string profile_url { get; set; }
        public string profile_banner { get; set; }
        public List<MythicPlusRecentRun> mythic_plus_recent_runs { get; set; }
    }


}
