using System;
using System.Collections.Generic;
using System.Text;

namespace ClashRoyale.Models
{
    public class Card
    {
        public string _id { get; set; }
        public string IdName { get; set; }
        public string Rarity { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Arena { get; set; }
        public int ElixirCost { get; set; }
        public int Order { get; set; }
        public int __v { get; set; }
    }
}
