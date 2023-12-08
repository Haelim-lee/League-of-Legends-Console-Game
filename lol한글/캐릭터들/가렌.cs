using lol.스킬들;
using System;

namespace lol
{
    public class 가렌 : 챔피언
    {
        
        public 가렌()
        {
            this.체력 = 620;
            this.마나 = 350;
            this.공격력 = 86;
            this.방어력 = 36;
            this.골드 = 50000000;

            this.초기체력 = 620;
            this.초기마나 = 350;
            this.초기공격력 = 86;
            this.초기방어력 = 36;


            this.이름 = "가렌";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 결정타();
            this.스킬[1] = new 용기();
            this.스킬[2] = new 심판();
            this.스킬[3] = new 데마시아의정의 ();

        }

       
       


    }
}