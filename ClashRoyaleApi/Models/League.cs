using System;
using System.Collections.Generic;
using System.Text;

namespace ClashRoyaleApi.Models
{
    public class League
    {
        public string _id { get; set; }
        public string IdName { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int VictoryGold { get; set; }
        public int MinTrophies { get; set; }
        public int Order { get; set; }
        public int Arena { get; set; }
        public int __v { get; set; }
        public List<string> Chests { get; set; }
    }
}
