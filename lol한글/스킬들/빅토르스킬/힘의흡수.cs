using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 힘의흡수 : 스킬, 스킬정보
    {
        public 힘의흡수()
        {
            this.이름 = "힘의흡수";
            this.소모마나 = 45;
            this.마법피해 = 50;
            this.보호막 = 30;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 50;
            플레이어.마나 -= 45;
            플레이어.체력 += 30;
            Console.WriteLine(유닛.이름 + "이 가 체력 50 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 45 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 보호막 30 을 얻었습니다.");
        }
    }
}
