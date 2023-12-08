using lol.스킬들;

namespace lol
{
    public  class 카직스 : 챔피언
    {
        public 카직스()
        {
            this.체력 = 572.8;
            this.마나 = 327.2;
            this.공격력 = 63;
            this.방어력 = 36;
            this.골드 = 500;

            this.초기방어력 = 36;
            this.초기체력 = 572.8;
            this.초기마나 = 327.2;
            this.초기공격력 = 63;
            
            this.이름 = "카직스";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 공포감지();
            this.스킬[1] = new 공허의가시();
            this.스킬[2] = new 도약();
            this.스킬[3] = new 공허의습격();
        }
    }
}