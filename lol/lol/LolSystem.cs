using lol.Model.Champions;
using Lol.Locations;
using Lol.Model;
using Lol.Team;
using System.Collections.Generic;

namespace Lol
{
    public abstract class LolSystem
    {
        #region Properties
        /// <summary>
        /// 레드팀
        /// </summary>
        public RedTeam RedTeam { get; set; } = new RedTeam();
        /// <summary>
        /// 블루팀
        /// </summary>
        public BlueTeam BlueTeam { get; set; } = new BlueTeam();
        /// <summary>
        /// 소환사 
        /// </summary>
        public Summoner Player { get; set; } = new Summoner();
        /// <summary>
        /// 모든 챔피언들
        /// </summary>
        public List<Champion> Champions { get; set; } = new List<Champion>();

        public CreateGame Game { get; set; } = new CreateGame();
        #endregion

        #region Constructor
        public LolSystem()
        {
            Champions.Add(new Garen());
            Champions.Add(new Jhin());
            Champions.Add(new Leona());
        }
        #endregion
    }
}