using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 공허의가시 : 스킬, 스킬정보
    {
        public 공허의가시()
        {
            this.이름 = "공허의가시";
            this.물리피해 = 80;
            this.소모마나 = 55;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 80;
            플레이어.마나 -= 55;

            Console.WriteLine(유닛.이름 + "이 체력 80 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 55 을 잃었습니다.");
        }
    }
}
