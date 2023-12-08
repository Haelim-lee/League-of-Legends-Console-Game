namespace Lol
{
    interface Unit
    {
        /// <summary>
        /// 이름
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 체력
        /// </summary>
        double HP { get; set; }
        /// <summary>
        /// 마나
        /// </summary>
        int MP { get; set; }
        /// <summary>
        /// 공격력
        /// </summary>
        double AD { get; set; }
        /// <summary>
        /// 방어력
        /// </summary>
        double Defense { get; set; }
        /// <summary>
        /// 경험치
        /// </summary>
        double EXP { get; set; }
        /// <summary>
        /// Goid
        /// </summary>
        int Gold { get; set; }
        /// <summary>
        /// 마법저항력
        /// </summary>
        double APResistance { get; set; }
        /// <summary>
        /// 주문력
        /// </summary>
        double AP { get; set; }
        /// <summary>
        /// 치명타
        /// </summary>
        int Critical { get; set; }
    }
}