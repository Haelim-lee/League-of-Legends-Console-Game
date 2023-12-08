using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 황금빛방패 : 스킬, 스킬정보
    {
        public 황금빛방패()
        {
            this.이름 = "황금빛방패";
            this.소모마나 = 30;
            this.보호막 = 60;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            플레이어.체력 += 60;
            플레이어.마나 -= 30;

            Console.WriteLine(플레이어.이름 + "이 보호막 60 을 얻었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 50 을 잃었습니다.");
        }
    }
}
