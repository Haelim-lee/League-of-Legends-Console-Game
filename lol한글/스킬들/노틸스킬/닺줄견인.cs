using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 닺줄견인 : 스킬, 스킬정보
    {
        public 닺줄견인()
        {
            this.마법피해 = 55;
            this.소모마나 = 50;
            this.이름 = "닺줄견인";
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 55;
            플레이어.마나 -= 50;
            Console.WriteLine(유닛.이름 + "이가 체력 55 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이가 마나 50 을 소모했습니다.");
            Console.WriteLine(유닛.이름 + "이 1.5초동안  기절하였습니다.");
            Thread.Sleep(1500);
        }
    }
}
