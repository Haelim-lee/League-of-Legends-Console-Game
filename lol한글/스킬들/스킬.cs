using lol.스킬들;

namespace lol
{
    public abstract class  스킬 
    {
        public int 물리피해 { get; set; }
        public int 소모마나 { get; set; }
        public int 마법피해 { get; set; }
        public int 보호막 { get; set; }
        public string 이름 { get; set; }

        public abstract void 스킬사용(유닛 유닛, 챔피언 플레이어);
    }
}