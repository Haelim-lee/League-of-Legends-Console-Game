using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 빛의속박 : 스킬, 스킬정보
    {
        public 빛의속박()
        {
            this.이름 = "빛의속박";
            this.마법피해 = 80;
            this.소모마나 = 70;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 80;
            플레이어.마나 -= 70;
            Console.WriteLine(유닛.이름 + "이 가 체력 80을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 70을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이 2초동안 속박되었습니다.");

        }
    }
}
