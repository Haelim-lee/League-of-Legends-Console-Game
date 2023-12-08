using lol.Model;
using lol.Model.Skills;
using Lol.Model.Skills;
using System.Collections.Generic;

namespace Lol.Model
{
    public class Champion : Unit
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public int MP { get; set; }
        public double AD { get; set; }
        public double Defense { get; set; }
        public double EXP { get; set; }
        public int Gold { get; set; }
        public double APResistance { get; set; }
        public double AP { get; set; }
        public int Critical { get; set; }
        public ePosition Position { get; set; }

        public int Kill { get; set; }
        public int Die { get; set; }
        public int Help { get; set; }

        public List<Skill> Skills { get; set; }

        public Champion()
        {
                
        }
    }
}