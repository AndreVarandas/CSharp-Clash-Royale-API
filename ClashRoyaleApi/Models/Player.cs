using System;
using System.Collections.Generic;
using System.Text;

namespace ClashRoyaleApi.Models
{
    public class Player
    {
        public string _id { get; set; }
        public string IdName { get; set; }
        public int Level { get; set; }
        public int MaxExp { get; set; }
        public int Order { get; set; }
        public int __v { get; set; }
        public ArenaTower ArenaTowers { get; set; }
        public KingsTower KingsTower { get; set; }
    }

    public class ArenaTower
    {
        public int HitPoints { get; set; }
        public double Range { get; set; }
        public int Damage { get; set; }
        public double HitSpeed { get; set; }
    }

    public class KingsTower
    {
        public int HitPoints { get; set; }
        public double Range { get; set; }
        public int Damage { get; set; }
        public double Hitspeed { get; set; }
    }
}
