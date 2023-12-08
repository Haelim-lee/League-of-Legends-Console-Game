using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 프리즘보호막 : 스킬, 스킬정보
    {
        public 프리즘보호막()
        {
            this.이름 = "프리즘보호막";
            this.소모마나 = 60;
            this.보호막 = 65;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            플레이어.체력 += 65;
            플레이어.마나 -= 60;
            Console.WriteLine(플레이어.이름 + "이 가 보호막 65 을 얻었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 60을 잃었습니다.");
        }
    }
}
