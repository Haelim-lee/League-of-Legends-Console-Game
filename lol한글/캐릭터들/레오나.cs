using lol.스킬들;

namespace lol
{
    public  class 레오나 : 챔피언
    {        

        public 레오나()
        {
            this.체력 = 576.16;
            this.마나 = 302.2;
            this.공격력 = 60;
            this.방어력 = 47;
            this.주문력 = 5;
            this.골드 = 500;

            this.초기체력 = 576.16;
            this.초기마나 = 302.2;
            this.초기주문력 = 5;
            this.초기방어력 = 47;
            this.초기공격력 = 60;

            this.이름 = "레오나";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 여명의방패();
            this.스킬[1] = new 일식();
            this.스킬[2] = new 천공의검();
            this.스킬[3] = new 흑점폭팔();
        }
    }
}