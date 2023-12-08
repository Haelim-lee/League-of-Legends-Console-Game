

namespace lol
{
    public  class 상점 : 장소
    {
        public 아이템[] 아이템 { get; set; }
        

        public 상점()
        {
            아이템 = new 아이템[6];
            아이템[0] = new 도란검();
            아이템[1] = new 도란반지();
            아이템[2] = new 도란방패();
            아이템[3] = new 물약();
            아이템[4] = new 잉걸불칼();
            아이템[5] = new 주문도둑검();
        }
    }
}