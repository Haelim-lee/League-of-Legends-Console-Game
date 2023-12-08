using System;
using System.Threading;

namespace lol
{
    public class 소환사 :유닛
    {
        public 챔피언 챔피언 { get; set; }
        public 라인 라인 { get; set; }
        public 장소 현재위치 { get; set; }
        public 아이템[] 인벤토리 { get; set; }

        public void 이동하다(장소 이동장소)
        {
            this.현재위치 = 이동장소;
        }

        public 소환사()
        {
            this.인벤토리 = new 아이템[6];
             
            Random 랜덤 = new Random();
            int 선택값 = 랜덤.Next(0, 3);
            switch (선택값)
            {
                case 0:
                    this.현재위치  = new 미드(); break;
                case 1:
                    this.현재위치 = new 탑(); break;
                case 2:
                    this.현재위치 = new 정글(); break;
                case 3:
                    this.현재위치 = new 바텀(); break;
                default:
                    break;
            }
        }





    }

}

