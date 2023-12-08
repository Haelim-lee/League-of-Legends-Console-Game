using lol.스킬들;

namespace lol
{
    public  class 오른 : 챔피언
    {
        public 오른()
        {
            this.체력 = 590;
            this.마나 = 300;
            this.공격력 = 69;
            this.방어력 = 33;
            this.주문력 = 3;
            this.골드 = 500;

            this.초기주문력 = 3;
            this.초기체력 = 590;
            this.초기공격력 = 69;
            this.초기방어력 = 33;
            this.초기마나 = 300;

            this.이름 = "오른";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 용암균열();
            this.스킬[1] = new 불꽃풀무질();
            this.스킬[2] = new 화염돌진();
            this.스킬[3] = new 대장장의신의부름();
        }
    }
}