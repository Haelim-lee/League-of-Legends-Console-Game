
using System;

namespace lol
{
    public  class 도란반지 :아이템, I아이템정보
    {
        public 도란반지()
        {
            this.체력 = 70;
            this.이름 = "도란반지";
            this.골드 = 450;
            this.주문력 = 15;
           
        }

        public void 아이템사용(챔피언 플레이어)
        {
           
            플레이어.체력 += 70;
            플레이어.주문력 += 15;
            
            Console.WriteLine(플레이어.이름 + "가 체력  70과 주문력 15를 얻었습니다.");
            
        }

        public void 아이템팔기(챔피언 플레이어)
        {
            throw new NotImplementedException();
        }
    }
}