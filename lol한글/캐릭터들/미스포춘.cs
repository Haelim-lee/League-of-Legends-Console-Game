using lol.스킬들;

namespace lol
{
    public  class 미스포춘 : 챔피언
    {
        public 미스포춘()
        {
            this.체력 = 570;
            this.마나 = 325.84;
            this.공격력 = 52;
            this.방어력 = 28;
            this.주문력 = 5;
            this.골드 = 500;

            this.초기공격력 = 52;
            this.초기마나 = 325.84;
            this.초기방어력 = 28;
            this.초기체력 = 570;
            this.초기주문력 = 5;

            this.이름 = "미스포춘";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 한발의두놈();
            this.스킬[1] = new 활보();
            this.스킬[2] = new 총알은비를타고();
            this.스킬[3] = new 쌍권총난사();
        }
    }
}