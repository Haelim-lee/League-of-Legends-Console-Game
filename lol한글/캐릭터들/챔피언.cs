using lol.스킬들;
using System;
using System.Collections.Generic;
using System.Threading;

namespace lol
{

    public class 챔피언 :유닛
    {
        public int 레벨 { get; set; }
        public int 보호막 { get; set; } 
        public double 치명타 { get; set; }
        public 시스템 시스템 { get; set; }
        public 스킬[] 스킬 { get; set; }
        public 팀 팀 { get; set; }
        public 스펠 스펠 { get; set; }
        public 아이템[] 인벤토리 { get; set; }
        
        
        public 챔피언()
        {
            
        }

        public void 내정보()
        {
            Console.WriteLine("이름 : + 이름");
            Console.WriteLine("레벨 : + 레벨 ");
            Console.WriteLine("체력 : + 체력");
            Console.WriteLine("마나 : + 마나");
            Console.WriteLine("공격력 : + 공격력");
            Console.WriteLine("방어력 : + 방어력");
            Console.WriteLine("치명타 : + 치명타");
            Console.WriteLine("경험치 : + 경험치");
            Console.WriteLine("골드 : + 골드");
            Console.WriteLine("주문력 : + 주문력");
            Thread.Sleep(1000);
        }

        public void 공격하기( 유닛 대상 )
        {
            Console.WriteLine("1.기본공격 2.스킬공격");
            string 공격선택 = Console.ReadLine();

            if (공격선택.Equals("1")) { 기본공격(대상); }
            else if (공격선택.Equals("2")) { 스킬시전(대상); }
            
            this.체력 -= 대상.공격력;
            Console.WriteLine(대상.이름 + "에게" + 대상.공격력 + "의 피해를 당했습니다.");
            Console.WriteLine(this.이름 + "현재체력 : " + this.체력);
            Console.WriteLine(this.이름 + "현재마나 : " + this.마나);
            Console.WriteLine(대상.이름 + "현재체력 : " + 대상.체력);
            Thread.Sleep(1000);

        }
        public  void 스킬시전(유닛 대상)
        {
            string 스킬들 = string.Empty;
            
            for (int 번호 = 0; 번호 < this.스킬.Length; 번호++)
            {
               스킬들 += 번호+1 +"."+ 스킬[번호].이름;
               
            }
            Console.WriteLine(스킬들);
            
            string 선택한스킬 = Console.ReadLine();
            스킬정보 사용할스킬 = this.스킬[Convert.ToInt32(선택한스킬)-1] as 스킬정보;
                        if (this.마나 > 스킬[Convert.ToInt32(선택한스킬) - 1].소모마나)

                            사용할스킬.스킬사용(대상, this);
                        else 
                          Console.WriteLine("마나가 부족합니다.");
            Thread.Sleep(1000);
                       
        }

        public void 기본공격(유닛 대상)
        {
            Console.WriteLine(이름 + "이가 공격합니다. " + this.공격력 + "의 피해를 가했습니다.");
            대상.체력 -= this.공격력;
            Thread.Sleep(1000);
        }


        public void 용공격하기(장소 용)
        {
            용.체력 -= this.공격력;
            Console.WriteLine(용.이름 + "에게" + this.공격력 + "의 피해를 입혔습니다.");
            Console.WriteLine(용.이름 + "체력 : " + 용.체력);
            Thread.Sleep(30);

            this.체력 -= 용.공격력;
            Console.WriteLine(용.이름 + "에게" + 용.공격력 + "의 피해를 당했습니다.");
            Console.WriteLine(this.이름 + "현재체력 : " + this.체력);

        }

        public void 포탑공격(장소 포탑)
        {
            if (포탑.체력 <= 0)
            {
                Console.WriteLine(this.이름 + "이 포탑을 파괴했습니다.");
                Thread.Sleep(150);
                this.골드 += 포탑.골드;
                Console.WriteLine(this.이름 + "이 골드 300을 얻었습니다.");
                Console.WriteLine("현재골드 : " + this.골드);
            }
            else
            {
                포탑.체력 -= this.공격력;
                Console.WriteLine(포탑.이름 + "에게" + this.공격력 + "의 피해를 입혔습니다.");
                Console.WriteLine(포탑.이름 + "체력 : " + 포탑.체력);  
            }
            return;

        }
        public void 억제기공격(장소 억제기)
        {
            if (억제기.체력 <= 0)
            {
                Console.WriteLine(this.이름 + "이 억제기를 파괴했습니다.");
                Thread.Sleep(150);
                this.골드 += 억제기.골드;
                시스템.나레이션(this.이름 + "이 골드" + 억제기.골드 + "을 얻었습니다.");
                시스템.나레이션("현재골드 :" + this.골드);
            }
            else
            {
                억제기.체력 -= this.공격력;
                시스템.나레이션(억제기.이름 + "에게" + this.공격력 + "피해를 입혔습니다.");
                시스템.나레이션(억제기.이름 + "체력 :" + 억제기.체력);
            }
            return;
        }

        public  void 바론공격하기(장소 바론)
        {
            바론.체력 -= this.공격력;
            Console.WriteLine(바론.이름 + "에게" + this.공격력 + "의 피해를 입혔습니다.");
            Console.WriteLine(바론.이름 + "체력 : " + 바론.체력);
            Thread.Sleep(30);

            this.체력 -= 바론.공격력;
            Console.WriteLine(바론.이름 + "에게" + 바론.공격력 + "의 피해를 당했습니다.");
            Console.WriteLine(this.이름 + "현재체력 : " + this.체력);
        }

        public void 부활()
        {
            this.체력 += this.초기체력;
            this.마나 += this.초기마나;
        }
    }
}