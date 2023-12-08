using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 쌍권총난사 : 스킬, 스킬정보
    {
        public 쌍권총난사()
        {
            this.소모마나 = 100;
            this.이름 = "쌍권총난사";
            this.물리피해 = 100;
            this.마법피해 = 50;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 150;
            플레이어.마나 -= 100;
            Console.WriteLine(유닛.이름 + "이 가 체력 150 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 100 을 잃었습니다.");
        }
    }
}
