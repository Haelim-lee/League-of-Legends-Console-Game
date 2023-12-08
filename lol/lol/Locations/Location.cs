using lol.Model;
using Lol.Model;

namespace Lol.Locations
{
    public abstract class Location
    {
        #region Properties
        /// <summary>
        /// 장소이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 위치 (진영)
        /// </summary>
        public eLocation Place { get; set; }

        /// <summary>
        /// 처치시 골드 
        /// </summary>
        public int Gold { get; set; }

        /// <summary>
        /// 처치시 경험치
        /// </summary>
        public double EXP { get; set; }

        /// <summary>
        /// 체력
        /// </summary>
        public double HP { get; set; }

        /// <summary>
        /// (데미지를 주지않는 경우도 있음)
        /// </summary>
        public double Damages { get; set; } 

        /// <summary>
        /// 존재 여부
        /// </summary>
        public bool IsExistence { get; set; }
        #endregion

        #region Funcions
        public abstract void Attack(Champion champion);
        #endregion
    }
}