using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 시간도약 : 스킬, 스킬정보
    {
        public 시간도약()
        {
            this.이름 = "시간도약";
            this.마법피해 = 50;
            this.소모마나 = 40;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 50;
            플레이어.마나 -= 40;

            Console.WriteLine(유닛.이름 + "이 체력 50 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 40 을 잃었습니다.");
        }
    }
}
