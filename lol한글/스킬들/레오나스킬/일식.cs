using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 일식 : 스킬, 스킬정보
    {
       public 일식()
       {
            this.소모마나 = 60;
            this.마법피해 = 60;
            this.보호막 = 10;
            this.이름 = "일식";
       }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 70;
            플레이어.체력 += 10;
            플레이어.마나 -= 60;
            Console.WriteLine(플레이어.이름 + "이 가 보호막 10 을 얻었습니다.");
            Console.WriteLine(유닛.이름 + "이 가 체력 60 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 60 을 잃었습니다.");
        }
    }
}
