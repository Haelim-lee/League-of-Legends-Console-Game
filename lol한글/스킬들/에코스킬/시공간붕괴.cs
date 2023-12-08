using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 시공간붕괴 : 스킬, 스킬정보
    {
        public 시공간붕괴()
        {
            this.이름 = "시공간붕괴";
            this.소모마나 = 100;
            this.마법피해 = 150;
            this.보호막 = 100;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            플레이어.체력 += 100;
            플레이어.마나 -= 100;
            유닛.체력 -= 150;

            Console.WriteLine(플레이어.이름 + "이 보호막 100 을 얻었습니다.");
            Console.WriteLine(유닛.이름 + "이 체력 150 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 100 을 잃었습니다.");
        }
    }
}
