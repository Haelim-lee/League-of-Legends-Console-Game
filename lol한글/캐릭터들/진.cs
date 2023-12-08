using lol.스킬들;

namespace lol
{
    public  class 진 : 챔피언
    {
        
        public 진()
        {
            this.체력 = 585;
            this.마나 = 300;
            this.공격력 = 59;
            this.방어력 = 24;
            this.주문력 = 4;
            this.골드 = 500;

            this.초기체력 = 585;
            this.초기주문력 = 4;
            this.초기마나 = 300;
            this.초기공격력 = 59;
            this.초기방어력 = 24;

            this.이름 = "진";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 춤추는유탄();
            this.스킬[1] = new 살상연희();
            this.스킬[2] = new 강제관람();
            this.스킬[3] = new 커튼콜();
        }
    }
}