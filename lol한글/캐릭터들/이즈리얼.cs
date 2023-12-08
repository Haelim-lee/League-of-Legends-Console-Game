using lol.스킬들;

namespace lol
{
    public  class 이즈리얼 : 챔피언
    {
        public 이즈리얼()
        {
            this.체력 = 530;
            this.마나 = 375;
            this.공격력 = 60;
            this.방어력 = 22;
            this.주문력 = 6;
            this.골드 = 500;

            this.초기마나 = 375;
            this.초기체력 = 530;
            this.초기공격력 = 60;
            this.초기방어력 = 22;
            this.초기주문력 = 6;



            this.이름 = "이즈리얼";
            this.스킬 = new 스킬[4];
            this.스킬[0] = new 신비한화살();
            this.스킬[1] = new 정수의흐름();
            this.스킬[2] = new 비전이동();
            this.스킬[3] = new 정조준일격();

        }
    }
}