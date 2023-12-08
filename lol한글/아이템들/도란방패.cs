
using System;

namespace lol
{
    public  class 도란방패 :아이템, I아이템정보
    {
        public 도란방패()
        {
            this.골드 = 450;
            this.이름 = "도란방패";
            this.체력 = 80;
            this.방어력 = 5;
            this.마법저항력 = 5;
            
        }

        public void 아이템사용(챔피언 플레이어)
        {
           
            플레이어.체력 += 80;
            플레이어.방어력 += 5;
            플레이어.마법저항력 += 5;
            플레이어.골드 -= 450;
            
            Console.WriteLine(플레이어.이름 + "가 체력 80과  방어력 5와  마법저항력 5를 얻었습니다.");
           
        }

        public void 아이템팔기(챔피언 플레이어)
        {
            throw new NotImplementedException();
        }
    }
}