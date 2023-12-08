using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 총알은비를타고 : 스킬, 스킬정보
    {
        public 총알은비를타고()
        {
            this.이름 = "총알을비를타고";
            this.소모마나 = 80;
            this.마법피해 = 80;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 80;
            플레이어.마나 -= 80;
            Console.WriteLine(유닛.이름 + "이 가 체력 80 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 80 을 잃었습니다.");
            
        }
    }
}
