using lol.스킬들;

namespace lol
{
    public  class 자르반 : 챔피언
    {
        public 자르반()
        {
            this.체력 = 570;
            this.마나 = 300;
            this.공격력 = 64;
            this.방어력 = 34;
            this.주문력 = 3;
            this.골드 = 500;

            this.초기주문력 = 3;
            this.초기체력 =570;
            this.초기공격력 = 64;
            this.초기방어력 = 34;
            this.초기마나 = 300;

            this.이름 = "자르반";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 용의일격();
            this.스킬[1] = new 황금빛방패();
            this.스킬[2] = new 데마시아의깃발();
            this.스킬[3] = new 대격변();
        }
    }
}