using lol.Model;
using Lol.Locations;
using Lol.Model;

namespace Lol
{
    public class Summoner : Unit
    {
        /// <summary>
        /// 챔피언
        /// </summary>
        public Champion Champion { get; set; }
        /// <summary>
        /// 포지션
        /// </summary>
        public ePosition Position { get; set; }
        /// <summary>
        /// 장소
        /// </summary>
        public Location Location { get; set; }
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
    }

}