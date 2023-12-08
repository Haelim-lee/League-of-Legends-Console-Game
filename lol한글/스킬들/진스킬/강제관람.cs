using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{//플레이어 넣어야댐 구현시키고 
    class 강제관람 : 스킬, 스킬정보
    {
        public 강제관람()
        {
            this.이름 = "강제관람";
            this.소모마나 = 30;
            this.물리피해 = 20;
            this.마법피해 = 10;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 30;
            플레이어.마나 -= 30;

            Console.WriteLine(유닛.이름 + "이 체력 30 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 30 을 잃었습니다.");
        }

       
    }
}
