using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 폭뢰 : 스킬, 스킬정보
    {
        public 폭뢰()
        {
            this.마법피해 = 150;
            this.소모마나 = 100;
            this.이름 = "폭뢰";
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 150;
            플레이어.마나 -= 100;
            Console.WriteLine(유닛.이름 + "이 가 체력 150을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 100을 잃었습니다.");
            Console.WriteLine(유닛.이름 + "이 1.5초동안 공중에 띄워졌습니다.");
            Thread.Sleep(1500);
        }
    }
}
