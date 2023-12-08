using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 살상연희 : 스킬, 스킬정보
    {
        public 살상연희()
        {
            this.소모마나 = 50;
            this.이름 = "살상연희";
            this.물리피해 = 50;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 50;
            플레이어.마나 -= 50;

            Console.WriteLine(유닛.이름 + "이 체력 50 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 50 을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이 1초동안 속박되었씁니다.");
        }
    }
}
