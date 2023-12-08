using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 시간의톱니바퀴 : 스킬, 스킬정보
    {
        public 시간의톱니바퀴()
        {
            this.마법피해 = 60;
            this.소모마나 = 50;
            this.이름 = "시간의톱니바퀴";
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 60;
            플레이어.마나 -= 50;

            Console.WriteLine(유닛.이름 + "이 체력 60 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 50 을 잃었습니다.");
        }
    }
}
