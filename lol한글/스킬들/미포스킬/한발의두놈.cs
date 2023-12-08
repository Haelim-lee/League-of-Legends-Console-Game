using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 한발의두놈 : 스킬, 스킬정보
    {
        public 한발의두놈()
        {
            this.물리피해 = 40;
            this.소모마나 = 43;
            this.이름 = "한발의두놈";
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 40;
            플레이어.마나 -= 43;
            Console.WriteLine(유닛.이름 + "이 가 체력 40 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 43 을 잃었습니다.");
        }
    }
}
