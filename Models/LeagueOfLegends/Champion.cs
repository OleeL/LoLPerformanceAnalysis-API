using System.Collections.Generic;

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Skin
    {
        public string id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public bool chromas { get; set; }
    }

    public class Info
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
    }

    public class Stats
    {
        public int hp { get; set; }
        public int hpperlevel { get; set; }
        public int mp { get; set; }
        public int mpperlevel { get; set; }
        public int movespeed { get; set; }
        public int armor { get; set; }
        public double armorperlevel { get; set; }
        public double spellblock { get; set; }
        public double spellblockperlevel { get; set; }
        public int attackrange { get; set; }
        public int hpregen { get; set; }
        public int hpregenperlevel { get; set; }
        public int mpregen { get; set; }
        public int mpregenperlevel { get; set; }
        public int crit { get; set; }
        public int critperlevel { get; set; }
        public int attackdamage { get; set; }
        public int attackdamageperlevel { get; set; }
        public double attackspeedperlevel { get; set; }
        public double attackspeed { get; set; }
    }

    public class Leveltip
    {
        public IList<string> label { get; set; }
        public IList<string> effect { get; set; }
    }

    public class Datavalues
    {
    }

    public class Spell
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public Leveltip leveltip { get; set; }
        public int maxrank { get; set; }
        public IList<int> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public IList<int> cost { get; set; }
        public string costBurn { get; set; }
        public Datavalues datavalues { get; set; }
        public IList<IList<int>> effect { get; set; }
        public IList<string> effectBurn { get; set; }
        public IList<object> vars { get; set; }
        public string costType { get; set; }
        public string maxammo { get; set; }
        public IList<int> range { get; set; }
        public string rangeBurn { get; set; }
        public Image image { get; set; }
        public string resource { get; set; }
    }

    public class Passive
    {
        public string name { get; set; }
        public string description { get; set; }
        public Image image { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public int count { get; set; }
        public bool hideCount { get; set; }
    }

    public class Block
    {
        public string type { get; set; }
        public bool recMath { get; set; }
        public bool recSteps { get; set; }
        public int minSummonerLevel { get; set; }
        public int maxSummonerLevel { get; set; }
        public string showIfSummonerSpell { get; set; }
        public string hideIfSummonerSpell { get; set; }
        public string appendAfterSection { get; set; }
        public IList<string> visibleWithAllOf { get; set; }
        public IList<string> hiddenWithAnyOf { get; set; }
        public IList<Item> items { get; set; }
    }

    public class Recommended
    {
        public string champion { get; set; }
        public string title { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
        public string customTag { get; set; }
        public int sortrank { get; set; }
        public bool extensionPage { get; set; }
        public bool useObviousCheckmark { get; set; }
        public object customPanel { get; set; }
        public IList<Block> blocks { get; set; }
    }

    public class Champion
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Image image { get; set; }
        public IList<Skin> skins { get; set; }
        public string lore { get; set; }
        public string blurb { get; set; }
        public IList<string> allytips { get; set; }
        public IList<string> enemytips { get; set; }
        public IList<string> tags { get; set; }
        public string partype { get; set; }
        public Info info { get; set; }
        public Stats stats { get; set; }
        public IList<Spell> spells { get; set; }
        public Passive passive { get; set; }
        public IList<Recommended> recommended { get; set; }
    }

    public class ChampionData
    {
        public Champion champion { get; set; }
    }