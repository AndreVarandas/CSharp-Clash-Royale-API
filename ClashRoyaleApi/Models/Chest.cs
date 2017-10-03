using System;
using System.Collections.Generic;
using System.Text;

namespace ClashRoyale.Models
{
    public class Chest
    {
        public string _id { get; set; }
        public string IdName { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int __v { get; set; }
        public Unlock Unlock { get; set; }
        public int GemCost { get; set; }
        public Gold Gold { get; set; }
        public Cards Cards { get; set; }
        public int Arena { get; set; }
    }

    public class Unlock
    {
        public int Time { get; set; }
        public int GemCost { get; set; }
    }

    public class Gold
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Cards
    {
        public int Number { get; set; }
        public int MinLegendary { get; set; }
        public int MinEpic { get; set; }
        public int MinRare { get; set; }
    }
}
