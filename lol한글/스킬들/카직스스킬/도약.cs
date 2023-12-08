﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.스킬들
{
    class 도약 : 스킬, 스킬정보
    {
        public 도약()
        {
            this.이름 = "도약";
            this.소모마나 = 50;
            this.물리피해 = 65;
        }
        public override void 스킬사용(유닛 유닛,챔피언 플레이어)
        {
            유닛.체력 -= 65;
            플레이어.마나 -= 50;

            Console.WriteLine(유닛.이름 + "이 체력 65 을 잃었습니다.");
            Console.WriteLine(플레이어.이름 + "이 마나 50 을 잃었습니다.");
        }
    }
}
