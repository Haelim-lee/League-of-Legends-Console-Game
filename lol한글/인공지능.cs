using System;
using System.Threading;

namespace lol
{
    public class 인공지능 : 플레이어
    {
       
        public 인공지능()
        {
            Thread.Sleep(100);
            Random 랜덤 = new Random();
            int 선택값 = 랜덤.Next(0, 15);

            switch (선택값)
            {
                case 0:
                    this.챔피언 = new 레오나(); 
                    this.이름 =  "레오나";
                    break;
                case 1:
                    this.챔피언 = new 럭스();
                    this.이름 = "럭스";
                    break;
                case 2:
                    this.챔피언 = new 가렌();
                    this.이름 = "가렌";
                    break;
                case 3:
                    this.챔피언 = new 진();
                    this.이름 = "진";
                    break;
                case 4:
                    this.챔피언 = new 카직스();
                    this.이름 = "카직스";
                    break;
                case 5:
                    this.챔피언 = new 잔나();
                    this.이름 = "잔나";
                    break;
                case 6:
                    this.챔피언 = new 자르반();
                    this.이름 = "자르반";
                    break;
                case 7:
                    this.챔피언 = new 이즈리얼();
                    this.이름 = "이즈리얼";
                    break;
                case 8:
                    this.챔피언 = new 오른();
                    this.이름 = "오른";
                    break;
                case 9:
                    this.챔피언 = new 우디르();
                    this.이름 = "우디르";
                    break;
                case 10:
                    this.챔피언 = new 빅토르();
                    this.이름 = "빅토르";
                    break;
                case 11:
                    this.챔피언 = new 미스포춘();
                    this.이름 = "미스포춘";
                    break;
                case 12:
                    this.챔피언 = new 다리우스();
                    this.이름 = "다리우스";
                    break;
                case 13:
                    this.챔피언 = new 노틸();
                    this.이름 = "노틸";
                    break;
                case 14:
                    this.챔피언 = new 에코();
                    this.이름 = "에코";
                    break;
                case 15:
                    this.챔피언 = new 오른();
                    this.이름 = "오른";
                    break;

                default:
                    break;


            }

            

        
        }

    }
}