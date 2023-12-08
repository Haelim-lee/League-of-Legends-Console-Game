

using System;

namespace lol
{
    public class 아이템 
    {
        public 챔피언 소유자 { get; set; }
        public int 골드 { get; set; }
        public int 공격력 { get; set; }
        public int 방어력 { get; set; }
        public int 주문력 { get; set; }
        public int 마법저항력 { get; set; }
        public double 치명타 { get; set; }
        public string 이름 { get; set; }
        public double 체력 { get; set; }
        public double 마나 { get; set; }
        public bool 착용중여부 { get; set; }


        public void 아이템착용(챔피언 소유자)
        {
            (this as I아이템정보).아이템사용(소유자);
            착용중여부 = true;
            
        }
       
       // public void 

        public  아이템()
        {
            
        }

       
    }
}