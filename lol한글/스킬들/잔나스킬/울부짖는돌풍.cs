using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 울부짖는돌풍 : 스킬, 스킬정보
    {
        public 울부짖는돌풍()
        {
            this.소모마나 = 60;
            this.이름 = "울부짖는돌풍";
            this.마법피해 = 75;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {

            유닛.체력 -= 75;
            플레이어.마나 -= 60;

            Console.WriteLine(유닛.이름 + "이 체력 75 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 60 을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이 1.25초동안 공중에 띄워졌습니다.");
            Thread.Sleep(1250);
        }
    }
}
