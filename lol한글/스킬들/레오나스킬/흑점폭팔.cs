using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 흑점폭팔 : 스킬, 스킬정보
    {
        public 흑점폭팔()
        {
            this.이름 = "흑점폭팔";
            this.소모마나 = 100;
            this.마법피해 = 100;
            this.보호막 = 30;
        }
        public override void 스킬사용(유닛 유닛, 챔피언 플레이어)
        {
            유닛.체력 -= 100;
            플레이어.마나 -= 100;
            플레이어.체력 += 30;
            Console.WriteLine(유닛.이름 + "이 가 체력 100 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 마나 100 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 가 보호막 30 을 얻었습니다.");
            Console.WriteLine(유닛.이름 + "이 2초동안 기절하였습니다.");
            Thread.Sleep(2000);
        }
    }
}
