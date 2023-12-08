using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 신비한화살 : 스킬, 스킬정보
    {
        public 신비한화살()
        {
            this.이름 = "신비한화살";
            this.소모마나 = 28;
            this.물리피해 = 20;
            this.마법피해 = 15;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 35;
            플레이어.마나 -= 28;

            Console.WriteLine(유닛.이름 + "이 체력 35 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 28 을 잃었습니다.");
        }
    }
}
