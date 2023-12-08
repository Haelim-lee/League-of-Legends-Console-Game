namespace lol
{
    public class 장소
    {
        public string 이름 { get; set; }
        public 소환사[] 챔피언들 { get; set; }
        public double 체력 { get; set; }
        public double 공격력 { get; set; }
        public 용 용 { get; set; }
        public int 골드 { get; set; }

        public string 챔피언추가(소환사 챔피언)
        {
            string 챔피언명단 = "";

            //1.이용자를 가장 첫번째 빈공간에 추가하는 루프
            for (int index=0; index <챔피언들.Length; index ++)
                if(챔피언들[index ]== null)
                {
                    챔피언들[index] = 챔피언;
                    break;
                }
            //2.이용자들의 리스크를 만드는 루프
            foreach (소환사 챔피언이름 in 챔피언들)
                if (챔피언이름 == null)
                    break;
                else
                    챔피언명단 += 챔피언이름.이름 + ",";

            return 챔피언명단;






        }





    }
}