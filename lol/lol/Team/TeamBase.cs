using lol.Model;
using Lol.Model;
using System.Collections.Generic;

namespace Lol.Team
{
    public abstract class TeamBase
    {
        /// <summary>
        /// 팀원들
        /// </summary>
        List<Champion> Champions { get; set; }
    }
}