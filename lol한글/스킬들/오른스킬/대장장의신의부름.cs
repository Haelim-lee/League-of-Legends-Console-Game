using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 대장장의신의부름 : 스킬, 스킬정보
    {
        public 대장장의신의부름()
        {
            this.이름 = "대장장의신의부름";
            this.마법피해 = 250;
            this.소모마나 = 100;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 250;
            플레이어.마나 -= 100;

            Console.WriteLine(유닛.이름 + "이 체력 250 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 100 을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이  1초동안 공중에 띄워졌습니다.");
            Thread.Sleep(1000);
        }
    }
}
