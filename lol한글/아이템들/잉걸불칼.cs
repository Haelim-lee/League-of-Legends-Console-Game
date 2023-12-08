
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol
{
    class 잉걸불칼 : 아이템, I아이템정보
    {
        public 잉걸불칼()
        {
            this.골드 = 400;
            this.체력 = 40;
            this.이름 = "잉걸불칼";
            this.공격력 = 6;
            this.방어력 = 5;

        }
        
        public void 아이템사용(챔피언 플레이어)
        {
            
            플레이어.체력 += 40;
            플레이어.공격력 += 6;
            플레이어.방어력 += 5;
            
            Console.WriteLine(플레이어.이름 + "가 체력  40과 방어력 5와 공격력 6을 얻었습니다.");

        }

        public void 아이템팔기(챔피언 플레이어)
        {
            throw new NotImplementedException();
        }
    }
}
