using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 거북이태세 : 스킬, 스킬정보
    {
        public 거북이태세()
        {
            this.소모마나 = 45;
            this.이름 = "거북이태세";
            this.보호막 = 60;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 += 60;
            플레이어.마나 -= 50;

            Console.WriteLine(유닛.이름 + "이 보호막 60 을 얻었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 45 을 잃었습니다.");
        }

       
    }
}
