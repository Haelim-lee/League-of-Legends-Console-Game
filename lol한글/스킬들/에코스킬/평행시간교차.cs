using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 평행시간교차 : 스킬, 스킬정보
    {
        public 평행시간교차()
        {
            this.이름 = "평행시간교차";
            this.보호막 = 80;
            this.소모마나 = 30;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            플레이어.체력 += 80;
            플레이어.마나 -= 30;

            Console.WriteLine(플레이어.이름 + "이 보호막 80 을 얻었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 30 을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이 1.25초동안 기절하였습니다.");
            Thread.Sleep(1250);
        }
    }
}
