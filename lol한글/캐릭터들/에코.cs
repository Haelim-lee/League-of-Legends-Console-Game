using lol.스킬들;

namespace lol
{
    public  class 에코 : 챔피언
    {
        public 에코()
        {
            this.체력 = 585;
            this.마나 = 280;
            this.공격력 = 58;
            this.방어력 = 32;
            this.주문력 = 12;
            this.골드 = 500;

            this.초기주문력 = 12;
            this.초기체력 = 585;
            this.초기방어력 = 32;
            this.초기공격력 = 58;
            this.초기마나 = 280;

            this.이름 = "에코";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 시간의톱니바퀴();
            this.스킬[1] = new 평행시간교차();
            this.스킬[2] = new 시간도약();
            this.스킬[3] = new 시공간붕괴();

        }
    }
}