using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 곰태세 : 스킬, 스킬정보
    {
        public 곰태세()
        {
            this.이름 = "곰태세";
            this.물리피해 = 60;
            this.소모마나 = 45;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 60;
            플레이어.마나 -= 45;

            Console.WriteLine(유닛.이름 + "이 체력 60 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 45 을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이 1초동안 기절하였습니다.");
            Thread.Sleep(1000);
        }

       
    }
}
