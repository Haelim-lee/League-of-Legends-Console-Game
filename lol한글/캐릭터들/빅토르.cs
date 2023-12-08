using lol.스킬들;

namespace lol
{
    public  class 빅토르 : 챔피언
    {
        public 빅토르()
        {
            this.체력 = 530;
            this.마나 = 405;
            this.공격력 = 53;
            this.방어력 = 23;
            this.주문력 = 12;
            this.골드 = 500;

            this.초기체력 = 530;
            this.초기마나 = 405;
            this.초기공격력 = 53;
            this.초기방어력 = 23;
            this.초기주문력 = 12;

            this.이름 = "빅토르";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 힘의흡수();
            this.스킬[1] = new 중력장();
            this.스킬[2] = new 죽음의광선();
            this.스킬[3] = new 혼돈의폭풍();
               
        }
    }
}