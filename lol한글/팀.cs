namespace lol
{
    public class 팀
    {
        public 미니언 미니언 { get; set; }
        public 플레이어[] 플레이어 { get; set; }
        public 인공지능 인공지능 { get; set; }
        
        public 블루팀 블루팀 { get; set; }
        public 레드팀 레드팀 { get;set; }
        public 챔피언 챔피언 { get; set; }

        public 팀()
        {
            this.미니언 = new 미니언();
            this.플레이어 = new 플레이어[5];
            this.플레이어[0] = new 인공지능();
            this.플레이어[1] = new 인공지능();
            this.플레이어[2] = new 인공지능();
            this.플레이어[3] = new 인공지능();
            this.플레이어[4] = new 인공지능();
        }
    }
}