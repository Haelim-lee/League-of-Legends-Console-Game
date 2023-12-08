
using System;

namespace lol
{
    public  class 도란검 : 아이템, I아이템정보
    {
        public 도란검()
        {
            this.공격력 = 8;
            this.체력 = 80;
            this.골드 = 450;
            this.이름 = "도란검";
                
        }

        public void 아이템사용(챔피언 플레이어)
        {
            
            플레이어.체력 += 80;
            플레이어.골드 -= 450;
            플레이어.공격력 += 8;
           
            Console.WriteLine(플레이어.이름 + "가 체력 80과 공격력 8을 얻었습니다.");
           
        }

        public void 아이템팔기(챔피언 플레이어)
        {
           
           
        }
    }

}