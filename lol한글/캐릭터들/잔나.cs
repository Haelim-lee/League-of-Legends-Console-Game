using lol.스킬들;

namespace lol
{
    public class 잔나 : 챔피언
    {
        public 잔나()
        {
            this.체력 = 500;
            this.마나 = 350;
            this.공격력 = 52;
            this.방어력 = 28;
            this.주문력 = 8;
            this.골드 = 500;

            this.초기마나 = 350;
            this.초기공격력 = 52;
            this.초기방어력 = 28;
            this.초기주문력 = 8;
            this.초기체력 = 500;

            this.이름 = "잔나";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 울부짖는돌풍();
            this.스킬[1] = new 서풍();
            this.스킬[2] = new 폭풍의눈();
            this.스킬[3] = new 계절풍();

        }
    }
}