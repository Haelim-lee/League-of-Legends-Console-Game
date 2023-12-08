using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 혼돈의폭풍 : 스킬, 스킬정보
    {
        public 혼돈의폭풍()
        {
            this.이름 = "혼돈의폭풍";
            this.마법피해 = 165;
            this.소모마나 = 100;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 165;
            플레이어.마나 -= 100;
            Console.WriteLine(유닛.이름 + "이 가 체력 165 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 100 을 잃었습니다.");
        }
    }
}
