using lol.스킬들;

namespace lol
{
    public class 노틸 : 챔피언
    {
       
        
        public 노틸()
            
        {
            
            this.체력 = 586.48;
            this.마나 = 400;
            this.공격력 = 61;
            this.방어력 = 29;
            this.주문력 = 8;
            this.골드 = 500;

            this.초기체력 = 586.48;
            this.초기주문력 = 8;
            this.초기마나 = 400;
            this.초기공격력 = 61;
            this.초기방어력 = 29;



            this.이름 = "노틸러스";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 닺줄견인();
            this.스킬[1] = new 타이탄의분노();
            this.스킬[2] = new 역조();
            this.스킬[3] = new 폭뢰();
        }
        
       
    }

}