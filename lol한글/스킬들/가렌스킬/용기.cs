using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 용기 : 스킬,스킬정보
    {
       
        public 용기()
        {
            this.보호막 = 70;
            this.소모마나 = 20;
            this.이름 = "용기";
        }

        public override void 스킬사용(유닛 유닛,챔피언  플레이어)
        {
            플레이어.체력 += 70;
            플레이어.마나 -= 20;
            Console.WriteLine(플레이어.이름 + "이가 보호막 70을 얻었습니다.");
            Console.WriteLine(플레이어.이름 + "이가 마나 20 을 소모했습니다.");
        }
    }
}
