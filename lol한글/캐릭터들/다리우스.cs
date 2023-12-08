using lol.스킬들;

namespace lol
{
    public  class 다리우스 : 챔피언
    {
        public 다리우스()
        {
            this.체력 = 582.24;
            this.마나 = 263;
            this.공격력 = 64;
            this.방어력 = 39;
            this.골드 = 500;

            this.초기체력 = 582.24;
            this.초기마나 = 263;
            this.초기공격력 = 64;
            this.초기방어력 = 39;

            this.이름 = "다리우스";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 학살();
            this.스킬[1] = new 마비의일격();
            this.스킬[2] = new 포획();
            this.스킬[3] = new 녹서스의단두대();
        }
    }
}