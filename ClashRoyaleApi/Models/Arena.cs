using System.Collections.Generic;

namespace ClashRoyale.Models
{
    public class Arena
    {
        public string _id { get; set; }
        public string IdName { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int VictoryGold { get; set; }
        public int MinTrophies { get; set; }
        public int Order { get; set; }
        public int __v { get; set; }
        public List<string> Leagues { get; set; }
        public List<string> CardUnlocks { get; set; }
        public List<string> Chests { get; set; }
        public Clan Clan { get; set; }
    }

    public class Clan
    {
        public Donate Donate { get; set; }
        public Request Request { get; set; }
    }

    public class Donate
    {
        public int Common { get; set; }
        public int Rare { get; set; }
    }

    public class Request
    {
        public int Common { get; set; }
        public int Rare { get; set; }
    }
}
