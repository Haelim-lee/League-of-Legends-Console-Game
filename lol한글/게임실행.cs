using System;

namespace lol
{
    public class 게임실행
    {
        public 데이터베이스관리자 데이터베이스 { get; set; }
        public 소환사 플레이어 { get; set; }
        public 시스템 시스템 { get; set; }
        public 인공지능[] 블루팀_인공지능 { get; set; }
        public 인공지능[] 레드팀_인공지능 { get; set; }
        public 블루팀 블루팀 { get; set; }
        public 레드팀 레드팀 { get; set; }
        public 장소[] 장소들 { get;  set; }
        public 상점 상점 { get;  set; }
        public 아이템 아이템 { get;  set; }
        public 챔피언 유닛 { get; set; }

        public 게임실행()
        {
            Console.WriteLine("로딩중 ...^^");
            이야기초기화();
            이야기시작();
        }

        public void 이야기시작()
        {
            소환사 플레이어 = this.플레이어 as 소환사;

            시스템.소환사생성(플레이어);
            시스템.라인선택(플레이어);
            시스템.챔피언선택(플레이어,플레이어.라인);
            시스템.게임시작(this);
        }

        public void 이야기초기화()
        {
            this.데이터베이스 = new 데이터베이스관리자();
            this.플레이어 = new 플레이어();
            this.시스템 = new 시스템();

            this.블루팀_인공지능 = new 인공지능[5];
            this.블루팀_인공지능[0] = new 인공지능();
            this.블루팀_인공지능[1] = new 인공지능();
            this.블루팀_인공지능[2] = new 인공지능();
            this.블루팀_인공지능[3] = new 인공지능();
            this.블루팀_인공지능[4] = new 인공지능();

            this.레드팀_인공지능 = new 인공지능[4];
            this.레드팀_인공지능[0] = new 인공지능();
            this.레드팀_인공지능[1] = new 인공지능();
            this.레드팀_인공지능[2] = new 인공지능();
            this.레드팀_인공지능[3] = new 인공지능();

            this.블루팀 = new 블루팀();
            this.블루팀.팀원 = new 소환사[5];
            this.블루팀.팀원[0] = 블루팀_인공지능[0];
            this.블루팀.팀원[1] = 블루팀_인공지능[1];
            this.블루팀.팀원[2] = 블루팀_인공지능[2];
            this.블루팀.팀원[3] = 블루팀_인공지능[3];
            this.블루팀.팀원[4] = 블루팀_인공지능[4];

            this.레드팀 = new 레드팀();
            this.레드팀.팀원 = new 소환사[5];
            this.레드팀.팀원[0] = 플레이어;
            this.레드팀.팀원[1] = 레드팀_인공지능[0];
            this.레드팀.팀원[2] = 레드팀_인공지능[1];
            this.레드팀.팀원[3] = 레드팀_인공지능[2];
            this.레드팀.팀원[4] = 레드팀_인공지능[3];

            this.시스템.블루팀 = this.블루팀;
            this.시스템.레드팀 = this.레드팀;

            this.장소들 = new 장소[10];
            this.장소들[0] = new 용();
            this.장소들[1] = new 상점();
            this.장소들[2] = new 탑();
            this.장소들[3] = new 미드();
            this.장소들[4] = new 정글();
            this.장소들[5] = new 바텀();
            this.장소들[6] = new 포탑();
            this.장소들[7] = new 억제기();
            this.장소들[8] = new 넥서스();
            this.장소들[9] = new 바론();
            
            this.시스템.장소들 = this.장소들;
            this.상점 = new 상점();

            this.아이템 = new 아이템();
        }
    }
}