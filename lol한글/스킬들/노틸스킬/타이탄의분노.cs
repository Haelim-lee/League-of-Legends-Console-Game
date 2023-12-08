using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 타이탄의분노 : 스킬, 스킬정보
    {
        public 타이탄의분노()
        {
            this.보호막 = 45;
            this.마법피해 = 30;
            this.소모마나 = 80;
            this.이름 = "타이탄의분노";
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 30;
            플레이어.마나 -= 80;
            플레이어.체력 += 45;
            Console.WriteLine(유닛.이름 + "이가 체력 30을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이가 마나 80을 소모했습니다.");
            Console.WriteLine(플레이어.이름 + "이가 보호막 45 을 얻었습니다.");
        }
    }
}
