using lol.스킬들;

namespace lol
{
    public  class 럭스 : 챔피언
    {



        public 럭스()
        {
            this.체력 = 490;
            this.마나 = 280;
            this.공격력 = 53.5;
            this.방어력 = 18.72;
            this.주문력 = 15;
            this.골드 = 500;

            this.초기체력 = 490;
            this.초기주문력 = 15;
            this.초기공격력 = 53.5;
            this.초기마나 = 280;
            this.초기방어력 = 18.72;
            
            this.이름 = "럭스";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 빛의속박();
            this.스킬[1] = new 프리즘보호막();
            this.스킬[2] = new 광휘의특이점();
            this.스킬[3] = new 최후의섬광();
        }
    }
}