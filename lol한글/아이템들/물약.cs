
using System;

namespace lol
{
    public  class 물약 : 아이템, I아이템정보
    {
        public 물약()
        {
            this.이름 = "물약";
            this.골드 = 50;
            this.체력 = 120;
        }

        public void 아이템사용(챔피언 플레이어)
        {
            
            플레이어.체력 += 120;
            플레이어.골드 -= 50;
            
            Console.WriteLine("물약을 사용하여 체력 120을 얻었습니다.");
            
        }

        public void 아이템팔기(챔피언 플레이어)
        {
            throw new NotImplementedException();
        }
    }
}