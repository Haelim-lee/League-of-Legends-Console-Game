using System;
using System.Threading;

namespace lol
{
    public class 시스템
    {
        public 데이터베이스관리자 데이터베이스 { get; set; }
        public 블루팀 블루팀 { get; set; }
        public 레드팀 레드팀 { get; set; }
        public 장소[] 장소들 { get;  set; }
        public 챔피언 챔피언 { get; set; }
        public 소환사 플레이어 { get; set; }
        
        public void 소환사생성(소환사 플레이어)
        {
            나레이션("게임을 시작합니다.");
            나레이션("닉네임을 입력하세요.");
            string 이름 = Console.ReadLine();
            플레이어.이름 = 이름;
          //  this.데이터베이스.명령수행("INSERT");
        }
        public void 라인선택(소환사 소환사)
        {
            나레이션("라인을 선택하세요");
            나레이션("1.미드 2.원딜 3.서포터 4.탑 5.정글");
            string 선택한라인 = Console.ReadLine();

            if (선택한라인.Equals("1")) { 소환사.라인 = new 미드(); }
            else if (선택한라인.Equals("2")) { 소환사.라인 = new 원딜(); }
            else if (선택한라인.Equals("3")) { 소환사.라인 = new 서포터(); }
            else if (선택한라인.Equals("4")) { 소환사.라인 = new 탑(); }
            else if (선택한라인.Equals("5")) { 소환사.라인 = new 정글(); }
            Console.WriteLine(소환사.라인.이름 + "을 선택하였습니다.");
        }

        public  void 게임시작(게임실행 게임실행)
        {
            나레이션("소환사의 협곡에 오신걸 환영합니다.");
            나레이션("블루팀과 싸워 포탑을 파괴하세요.");

            foreach (소환사 소환사 in 블루팀.팀원)
                나레이션( "블루팀 : " + 소환사.이름 );

            foreach (소환사 소환사 in 레드팀.팀원)
                나레이션("레드팀 :" + 소환사.이름);

            Thread.Sleep(300);
            while (선택지()) ;
        }

        public bool 선택지()
        {
            Console.Clear();
            소환사 플레이어 = 레드팀.팀원[0];
            미드 미드 = 장소들[3]as 미드;
            탑 탑 = 장소들[2] as 탑;
            정글 정글 =  장소들[4] as 정글;
            바텀 바텀 = 장소들[5] as 바텀;
            상점 상점 = 장소들[1] as 상점;
            용 용 = 장소들[0] as 용;
            바론 바론 = 장소들[9] as 바론;


            나레이션("1.미드이동 2.탑이동 3.바텀이동 4.정글이동 5.상점 6.게임종료");
            string 선택 = Console.ReadLine();

            switch (선택)
            {
               
                case "1":
                    나레이션("미드로 이동합니다.");
                    플레이어.현재위치 = 미드;
                    나레이션(플레이어.이름 + "가 미드에 있습니다.");
                    Thread.Sleep(30);

                    foreach (소환사 소환사 in 블루팀.팀원)
                    {
                        나레이션(소환사.이름 + "가" + 소환사.현재위치.이름 + "에 있습니다.");
                        Thread.Sleep(50);
                    }

                    전투(레드팀, 블루팀);
                    return true;

                case "2":
                    나레이션("탑으로 이동합니다.");
                    플레이어.현재위치 = 탑;
                    나레이션(플레이어.이름 + "가 탑에 있습니다.");

                    foreach (소환사 소환사 in 블루팀.팀원)
                    {
                        나레이션(소환사.이름 + "가" + 소환사.현재위치.이름 + "에 있습니다.");
                        Thread.Sleep(50);
                    }
                        
                    전투(레드팀, 블루팀);
                    return true;

                case "3":
                    나레이션("바텀으로 이동합니다.");
                    플레이어.현재위치 = 바텀;
                    나레이션(플레이어.이름 + "가 바텀에 있습니다.");

                    foreach (소환사 소환사 in 블루팀.팀원)
                    {
                        나레이션(소환사.이름 + "가" + 소환사.현재위치.이름 + "에 있습니다.");
                        Thread.Sleep(50);
                    }
                       
                    전투(레드팀, 블루팀);
                    return true;

                case "4":
                    나레이션("정글으로 이동합니다.");
                    플레이어.현재위치 = 정글;
                    나레이션("1.용 2.바론");
                    string 선택한정글 = Console.ReadLine();

                    if (선택한정글.Equals("1")) 
                    {
                        나레이션("용으로 이동합니다.");
                        플레이어.현재위치 = 용;
                        
                        foreach (소환사 소환사 in 블루팀.팀원)
                        {
                            나레이션(소환사.이름 + "가" + 소환사.현재위치.이름 + "에 있습니다.");
                            Thread.Sleep(50);
                        }
                        용사냥(플레이어, 용);
                    }
                    else if (선택한정글.Equals("2")) 
                    {
                        나레이션("바론으로 이동합니다.");
                        플레이어.현재위치 = 바론;
                        바론사냥(플레이어, 바론);

                        foreach (소환사 소환사 in 블루팀.팀원)
                        {
                            나레이션(소환사.이름 + "가" + 소환사.현재위치.이름 + "에 있습니다.");
                            Thread.Sleep(50);
                        }
                        바론사냥(플레이어, 바론);
                    }

                    return true;

                case "5":
                    나레이션("상점으로 이동합니다.");
                    플레이어.현재위치 = 상점;
                    나레이션(플레이어.이름 + "가 상점에 있습니다.");
                    쇼핑(플레이어);
                    return true;

                case "6":
                    게임종료(플레이어);
                    return false ;
                    
                default:
                    나레이션("잘못선택했습니다.");
                    return true;


                    
            }
            
        }

        public void 바론사냥(소환사 플레이어, 바론 바론)
        {
            while (true)
            {
                if (바론.체력 < 0)
                {
                    Console.WriteLine("바론이 없습니다.");
                    break;
                }

                Console.WriteLine("1.바론공격 2.도망가기");
                string 공격선택 = Console.ReadLine();

                if (공격선택.Equals("1"))
                {
                    플레이어.챔피언.바론공격하기(바론);

                    if ((플레이어.챔피언.체력 > 0) && (바론.체력 < 0))
                    {
                        Console.WriteLine(플레이어.이름 + "이 바론을 처치했습니다.");
                        플레이어.챔피언.골드 += 바론.골드;
                        플레이어.챔피언.공격력 += 20;
                        Console.WriteLine("골드 1000 과 공격력 20 을 얻었습니다.");
                        Console.WriteLine("현재골드 : " + 플레이어.챔피언.골드);
                        Console.WriteLine("현재공격력 : " + 플레이어.챔피언.공격력);
                        플레이어.챔피언.체력 += 플레이어.챔피언.초기체력;
                        Thread.Sleep(200);
                        break;
                    }
                    else if ((플레이어.챔피언.체력 < 0) && (바론.체력 > 0))
                    {
                        Console.WriteLine(플레이어.챔피언.이름 + "이 바론에게 당했습니다.");
                        Thread.Sleep(300);
                        Console.WriteLine(플레이어.챔피언.이름 + "이 부활하였습니다.");
                        플레이어.챔피언.부활();
                        break;
                    }
                }
                else if (공격선택.Equals("2"))
                {
                    선택지();

                }
            }
        }

        public void 전투(레드팀 레드팀 , 블루팀 블루팀)
        {
            
            포탑 포탑 = 장소들[6] as 포탑;
            소환사 플레이어 = 레드팀.팀원[0] ;
            
            while (true)
            {
                foreach (소환사 현재위치 in 블루팀.팀원)
                {
                    for (int i = 0; i < 블루팀.팀원.Length; i++)
                    {
                        if (블루팀.팀원[i].현재위치.이름 == 플레이어.현재위치.이름)
                        {
                            if ((플레이어.챔피언.체력 > 0) && (블루팀.팀원[i].챔피언.체력 > 0))
                            {
                                플레이어.챔피언.공격하기(블루팀.팀원[i].챔피언);
                                선택지();
                            }
                            else
                            {
                                if (플레이어.챔피언.체력 > 0)
                                {
                                    Console.WriteLine(블루팀.팀원[i].이름 + "이 사망하였습니다.");
                                    Thread.Sleep(3000);
                                    플레이어.챔피언.골드 += 블루팀.팀원[i].챔피언.골드;
                                    Console.WriteLine(플레이어.이름 + "이" + 블루팀.팀원[i].이름 + "의 골드를 뺏었습니다.");
                                    Console.WriteLine("현재골드 : " + 플레이어.챔피언.골드);

                                    if (포탑.체력 >= 0)
                                    {
                                        플레이어.챔피언.포탑공격(포탑);
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("플레이어가 사망하였습니다.");
                                    Thread.Sleep(3000);
                                    Console.WriteLine(블루팀.팀원[i].이름 + "이" + 플레이어.이름 + "의 골드를 뺏었습니다.");
                                    블루팀.팀원[i].챔피언.골드 += 플레이어.챔피언.골드;
                                    플레이어.챔피언.부활();
                                    Console.WriteLine(플레이어.이름 + "이 부활했습니다.");
                                    선택지();
                                }
                                break;
                            }
                        }
                        else
                        {
                            선택지();
                        }
                    }
                }
            }
            Thread.Sleep(300);
        }

        public void 용사냥(소환사 플레이어 ,장소 용)
        {
            while (true)
            {
                if (용.체력 < 0)
                {
                    Console.WriteLine("용이 없습니다.");
                    break;
                }

                Console.WriteLine("1.용공격 2.도망가기");
                string 공격선택 = Console.ReadLine();

                if (공격선택.Equals("1"))
                {
                        플레이어.챔피언.용공격하기(용);

                    if ((플레이어.챔피언.체력 > 0) && (용.체력 < 0))
                    {
                        Console.WriteLine("용을 처치했습니다.");
                        플레이어.챔피언.골드 += 용.골드;
                        플레이어.챔피언.공격력 += 20;
                        Console.WriteLine("골드 1000 과 공격력 20 을 얻었습니다.");
                        Console.WriteLine("현재골드 : " + 플레이어.챔피언.골드);
                        Console.WriteLine("현재공격력 : " + 플레이어.챔피언.공격력);
                        플레이어.챔피언.체력 += 플레이어.챔피언.초기체력;
                        Thread.Sleep(200);
                        break;
                    }
                    else if ((플레이어.챔피언.체력 < 0) && (용.체력 > 0))
                    {
                        Console.WriteLine(플레이어.챔피언.이름 + "이 용에게 당했습니다.");
                        Thread.Sleep(300);
                        Console.WriteLine(플레이어.챔피언.이름 + "이 부활하였습니다.");
                        플레이어.챔피언.부활();
                        break;
                    }
                }
                else if (공격선택.Equals("2"))
                {
                    선택지();
                }
            }
        }

        public void 쇼핑(소환사 플레이어)
        {
            상점 상점 = this.장소들[1] as 상점;
            아이템 도란검 = 상점.아이템[0] as 아이템;
            아이템 도란반지 = 상점.아이템[1] as 아이템;
            아이템 도란방패 = 상점.아이템[2] as 아이템;
            아이템 물약 = 상점.아이템[3] as 아이템;
            아이템 잉걸불칼 = 상점.아이템[4] as 아이템;
            아이템 주문도둑검 = 상점.아이템[5] as 아이템;
           
           

            Console.WriteLine("아이템을 선택해주세요.");
            Console.WriteLine("현재골드 : " + 플레이어.챔피언.골드);
            Console.WriteLine("1.도란검(450골드) 2. 도란반지(450골드) 3. 도란방패(450골드) 4.잉걸불칼(400골드) 5. 주문도둑검(400골드) 6.물약(50골드)");

            string 선택한아이템 = Console.ReadLine();
            if (선택한아이템.Equals("1"))
            {
                for (int i = 0; i < 플레이어.인벤토리.Length; i++)
                {
                    if (플레이어.인벤토리[i] == null)
                    {
                        if (플레이어.챔피언.골드> 도란검.골드)
                        {
                            플레이어.인벤토리[i] = 도란검;
                            플레이어.챔피언.골드 -= 도란검.골드;
                            Console.WriteLine("인벤토리에 도란검이 추가되었습니다.");
                            Console.WriteLine("현재골드 :" + 플레이어.챔피언.골드);
                            //for (int 아이템 = 0; i < 플레이어.인벤토리.Length; i++)
                            //{
                            //    나레이션(플레이어.이름 + "인벤토리" + 플레이어.인벤토리);
                            //    Thread.Sleep(50);
                            //}
                            //물약은 null로 빼면댐
                            // Console.WriteLine(this.이름 + "을 팔겠습니까?");
                            //Console.WriteLine("1.예 2.아니오");
                            //string 선택한값 = Console.ReadLine();

                            //if (선택한값.Equals("1"))
                            //{
                            //    플레이어.체력 -= 80;
                            //    플레이어.골드 += 300;
                            //    플레이어.공격력 -= 8;

                            //    Console.WriteLine(플레이어.이름 + "가 골드 300을 얻었습니다.");

                            //    소유자.인벤토리
                            //}
                            //else
                            //{
                            //    return;
                            //}
                            string 선택아이템 = 플레이어.인벤토리[i].이름;
                            플레이어.인벤토리[i].아이템착용(플레이어.챔피언);
                            
                            foreach (아이템 item in 플레이어.인벤토리)
                            {
                                if (item == null)
                                    continue;
                                나레이션(item.이름);
                                Thread.Sleep(50);
                            }
                            
                            return;
                        }
                        else
                        {
                            Console.WriteLine("골드가 부족합니다.");
                        }
                    }
                }
            }
            else if (선택한아이템.Equals("2"))
            {
                플레이어.챔피언.골드 -= 도란반지.골드;
                for (int i = 0; i < 플레이어.인벤토리.Length; i++)
                {
                    if (플레이어.인벤토리[i] == null)
                    {
                        플레이어.인벤토리[i] = 도란반지;
                        Console.WriteLine("인벤토리에 도란반지가 추가되었습니다.");
                        Console.WriteLine("현재골드 :" + 플레이어.챔피언.골드);
                        return;
                    }
                }
            }
            else if (선택한아이템.Equals("3"))
            {
                플레이어.챔피언.골드 -= 도란방패.골드;
                for (int i = 0; i < 플레이어.인벤토리.Length; i++)
                {
                    if (플레이어.인벤토리[i] == null)
                    {
                        플레이어.인벤토리[i] = 도란방패;
                        Console.WriteLine("인벤토리에 도란방패가 추가되었습니다.");
                        Console.WriteLine("현재골드 :" + 플레이어.챔피언.골드);
                        return;
                    }
                }
            }
            else if (선택한아이템.Equals("4"))
            {
                플레이어.챔피언.골드 -= 잉걸불칼.골드;
                for (int i = 0; i < 플레이어.인벤토리.Length; i++)
                {
                    if (플레이어.인벤토리[i] == null)
                    {
                        플레이어.인벤토리[i] = 잉걸불칼;
                        Console.WriteLine("인벤토리에 잉걸불칼이 추가되었습니다.");
                        Console.WriteLine("현재골드 : " + 플레이어.챔피언.골드);
                        return;
                    }
                }
            }
            else if (선택한아이템.Equals("5"))
            {
                플레이어.챔피언.골드 -= 주문도둑검.골드;
                for (int i = 0; i < 플레이어.인벤토리.Length; i++)
                {
                    if (플레이어.인벤토리[i] == null)
                    {
                        플레이어.인벤토리[i] = 주문도둑검;
                        Console.WriteLine("인벤토리에 주문도둑검이 추가되었습니다.");
                        Console.WriteLine("현재골드 :" + 플레이어.챔피언.골드);
                        return;
                    }
                }
            }
            else if (선택한아이템.Equals("6"))
            {
                플레이어.챔피언.골드 -= 물약.골드;
                for (int i = 0; i < 플레이어.인벤토리.Length; i++)
                {
                    if (플레이어.인벤토리[i] == null)
                    {
                        플레이어.인벤토리[i] = 물약;
                        Console.WriteLine("인벤토리에 물약이 추가되었습니다.");
                        Console.WriteLine("현재골드 :" + 플레이어.챔피언.골드);
                        return;
                    }
                }
            }

        }
        public void 챔피언선택(소환사 소환사,라인 선택한라인)
        { 
            
            if (선택한라인.GetType() == typeof(미드)) 
                선택(소환사, new 챔피언[3] { new 럭스(), new 에코(), new 빅토르() }, 선택한라인);
            else if (선택한라인.GetType() == typeof(원딜))
                선택(소환사, new 챔피언[3] { new 진(), new 미스포춘(), new 이즈리얼() }, 선택한라인);
            else if (선택한라인.GetType() == typeof(서포터))
                선택(소환사, new 챔피언[3] { new 레오나(), new 노틸(), new 잔나() }, 선택한라인);
            else if (선택한라인.GetType() == typeof(정글))
                선택(소환사, new 챔피언[3] { new 카직스(), new 자르반(), new 우디르() }, 선택한라인);
            else if (선택한라인.GetType() == typeof(탑))
                선택(소환사, new 챔피언[3] { new 가렌(), new 다리우스(), new 오른() }, 선택한라인);
        }

        private void 선택(소환사 소환사, 챔피언[] 챔피언들,라인 선택한라인)
        {
            Console.WriteLine("챔피언을 선택하세요");
            나레이션(string.Format("1.{0} 2.{1} 3.{2}", 챔피언들[0].이름, 챔피언들[1].이름, 챔피언들[2].이름));
            string 선택한챔피언 = Console.ReadLine();

            if (선택한챔피언.Equals("1")) { 소환사.챔피언 = 챔피언들[0]; }
            else if (선택한챔피언.Equals("2")) { 소환사.챔피언 = 챔피언들[1]; }
            else if (선택한챔피언.Equals("3")) { 소환사.챔피언 = 챔피언들[2]; }
            else
            {
                Console.WriteLine("다시선택해주세요");
                챔피언선택(소환사, 선택한라인);
            }
        }

        public void 게임종료 (소환사 플레이어)
        {
            Console.WriteLine("게임을 종료합니다.");
            Thread.Sleep(1000);
        }

        public void 나레이션(string 대사)
        {
            Console.WriteLine(대사);
            Thread.Sleep(100);
        }
    }
}