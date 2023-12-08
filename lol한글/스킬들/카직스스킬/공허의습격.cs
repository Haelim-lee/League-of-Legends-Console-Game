using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 공허의습격 : 스킬, 스킬정보
    {
        public 공허의습격()
        {
            this.이름 = "공허의습격";
            this.보호막 = 250;
            this.소모마나 = 100;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            플레이어.체력 += 250;
            플레이어.마나 -= 100;

            Console.WriteLine(플레이어.이름 + "이 체력 250 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 100 을 잃었습니다.");
        }
    }
}
