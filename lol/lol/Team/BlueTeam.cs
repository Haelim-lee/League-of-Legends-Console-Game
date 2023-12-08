using lol.Model;
using Lol.Model;
using System.Collections.Generic;

namespace Lol.Team
{
    public class BlueTeam : TeamBase
    {
        /// <summary>
        /// 팀원들
        /// </summary>
        public List<Champion> Champions { get; set; } = new List<Champion>();

        /// <summary>
        /// 진행방향
        /// </summary>
        public eDirection Direction => eDirection.Under;
    }
}