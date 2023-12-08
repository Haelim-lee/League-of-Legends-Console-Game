using lol.스킬들;

namespace lol
{
    public  class 우디르 : 챔피언
    {
        public 우디르()
        {
            this.체력 = 594;
            this.마나 = 271;
            this.공격력 = 66;
            this.방어력 = 34;
            this.주문력 = 3;
            this.골드 = 500;

            this.초기주문력 = 3;
            this.초기공격력 = 66;
            this.초기체력 = 594;
            this.초기방어력 = 34;
            this.초기마나 = 271;

            this.이름 = "우디르";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 호랑이태세();
            this.스킬[1] = new 거북이태세();
            this.스킬[2] = new 곰태세();
            this.스킬[3] = new 불사조태세();
        }
    }
}