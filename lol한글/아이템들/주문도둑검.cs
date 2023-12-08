
using System;

namespace lol
{
    public  class 주문도둑검 :아이템, I아이템정보
    {
        public 주문도둑검()
        {
            this.주문력 = 8;
            this.체력 = 10;
            this.골드 = 400;
            this.이름 = "주문도둑검";
        }

        public void 아이템사용(챔피언 플레이어)
        {
            플레이어.체력 += 10;
            플레이어.주문력 += 8;
            플레이어.골드 -= 400;
            
            Console.WriteLine(플레이어.이름 + "가 체력 10과 주문력 8을 얻었습니다.");

        }

        public void 아이템팔기(챔피언 플레이어)
        {
            throw new NotImplementedException();
        }
    }
}