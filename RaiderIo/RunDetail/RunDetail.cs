using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiderIo.RunDetail
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AzeritePower
    {
        public int id { get; set; }
        public Spell spell { get; set; }
        public int tier { get; set; }
    }

    public class Back
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Character
    {
        public int id { get; set; }
        public int persona_id { get; set; }
        public string name { get; set; }
        public Class @class { get; set; }
        public Race race { get; set; }
        public string faction { get; set; }
        public int level { get; set; }
        public Spec spec { get; set; }
        public string path { get; set; }
        public Realm realm { get; set; }
        public Region region { get; set; }
        public object stream { get; set; }
        public List<object> recruitmentProfiles { get; set; }
        public TalentLoadout talentLoadout { get; set; }
    }

    public class Chest
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<AzeritePower> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public string tier { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Class
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Corruption
    {
        public int added { get; set; }
        public int resisted { get; set; }
        public int total { get; set; }
        public int cloakRank { get; set; }
        public List<object> spells { get; set; }
    }

    public class Dungeon
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public string slug { get; set; }
        public int expansion_id { get; set; }
        public string icon_url { get; set; }
        public string patch { get; set; }
        public int keystone_timer_ms { get; set; }
        public int num_bosses { get; set; }
        public List<int> group_finder_activity_ids { get; set; }
    }

    public class Entry
    {
        public int id { get; set; }
        public int traitDefinitionId { get; set; }
        public int type { get; set; }
        public int maxRanks { get; set; }
        public Spell spell { get; set; }
    }

    public class Feet
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Finger1
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<int> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Finger2
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<int> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Guild
    {
        public int id { get; set; }
        public string name { get; set; }
        public string faction { get; set; }
        public Realm realm { get; set; }
        public Region region { get; set; }
        public string path { get; set; }
    }

    public class Hands
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public string tier { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Head
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<AzeritePower> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<int> gems { get; set; }
        public List<int> bonuses { get; set; }
        public string tier { get; set; }
    }

    public class Items
    {
        public DateTime updated_at { get; set; }
        public int item_level_equipped { get; set; }
        public int item_level_total { get; set; }
        public int artifact_traits { get; set; }
        public Corruption corruption { get; set; }
        public Items items { get; set; }
        public Head head { get; set; }
        public Neck neck { get; set; }
        public Shoulder shoulder { get; set; }
        public Back back { get; set; }
        public Chest chest { get; set; }
        public Waist waist { get; set; }
        public Wrist wrist { get; set; }
        public Hands hands { get; set; }
        public Legs legs { get; set; }
        public Feet feet { get; set; }
        public Finger1 finger1 { get; set; }
        public Finger2 finger2 { get; set; }
        public Trinket1 trinket1 { get; set; }
        public Trinket2 trinket2 { get; set; }
        public Mainhand mainhand { get; set; }
        public Offhand offhand { get; set; }
        public Shirt shirt { get; set; }
    }

    public class Legs
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public string tier { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Loadout
    {
        public Node node { get; set; }
        public int entryIndex { get; set; }
        public int rank { get; set; }
    }

    public class Mainhand
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Neck
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<int> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Node
    {
        public int id { get; set; }
        public int treeId { get; set; }
        public int type { get; set; }
        public List<Entry> entries { get; set; }
        public bool important { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public int row { get; set; }
        public int col { get; set; }
    }

    public class Offhand
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Race
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string faction { get; set; }
    }

    public class Ranks
    {
        public double score { get; set; }
        public int world { get; set; }
        public int region { get; set; }
        public int realm { get; set; }
    }

    public class Realm
    {
        public int id { get; set; }
        public int connectedRealmId { get; set; }
        public string name { get; set; }
        public object altName { get; set; }
        public string slug { get; set; }
        public string altSlug { get; set; }
        public string locale { get; set; }
        public bool isConnected { get; set; }
    }

    public class Region
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string short_name { get; set; }
    }

    public class RunDetail

    {
        public string season { get; set; }
        public string status { get; set; }
        public Dungeon dungeon { get; set; }
        public int keystone_run_id { get; set; }
        public int mythic_level { get; set; }
        public int clear_time_ms { get; set; }
        public int keystone_time_ms { get; set; }
        public DateTime completed_at { get; set; }
        public int num_chests { get; set; }
        public int time_remaining_ms { get; set; }
        public object logged_run_id { get; set; }
        public List<object> videos { get; set; }
        public List<WeeklyModifier> weekly_modifiers { get; set; }
        public int num_modifiers_active { get; set; }
        public string faction { get; set; }
        public object deleted_at { get; set; }
        public double score { get; set; }
        public object logged_details { get; set; }
        public int replay_limit { get; set; }
        public int keystone_team_id { get; set; }
        public object keystone_platoon_id { get; set; }
        public bool isTournamentProfile { get; set; }
        public List<Roster> roster { get; set; }
        public bool canManageOwnVideos { get; set; }
        public bool canManageOthersVideos { get; set; }
        public List<object> loggedSources { get; set; }
        public bool isPatron { get; set; }
    }

    public class Roster
    {
        public Character character { get; set; }
        public object oldCharacter { get; set; }
        public bool isTransfer { get; set; }
        public Guild guild { get; set; }
        public string role { get; set; }
        public Items items { get; set; }
        public Ranks ranks { get; set; }
    }

    public class Shirt
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<object> bonuses { get; set; }
    }

    public class Shoulder
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<AzeritePower> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public string tier { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Spec
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int class_id { get; set; }
        public string role { get; set; }
        public bool is_melee { get; set; }
        public string patch { get; set; }
    }

    public class Spell
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int school { get; set; }
        public string rank { get; set; }
        public bool hasCooldown { get; set; }
    }

    public class TalentLoadout
    {
        public int specId { get; set; }
        public List<Loadout> loadout { get; set; }
        public string loadoutText { get; set; }
    }

    public class Trinket1
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Trinket2
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<object> gems { get; set; }
        public List<int> bonuses { get; set; }
    }

    public class Waist
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<int> gems { get; set; }
        public List<int> bonuses { get; set; }
        public int? enchant { get; set; }
    }

    public class WeeklyModifier
    {
        public int id { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Wrist
    {
        public int item_id { get; set; }
        public int item_level { get; set; }
        public int enchant { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int item_quality { get; set; }
        public bool is_legendary { get; set; }
        public bool is_azerite_armor { get; set; }
        public List<object> azerite_powers { get; set; }
        public Corruption corruption { get; set; }
        public List<object> domination_shards { get; set; }
        public List<int> gems { get; set; }
        public List<int> bonuses { get; set; }
    }


}
