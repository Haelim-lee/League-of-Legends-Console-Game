namespace lol
{
    public class 라인 :장소
    {
        public string 플레이어 { get; set; }
        public 챔피언[] 이용자들 { get; set; }
        
        public string 이용자추가(플레이어 챔피언)
        {
           string  챔피언명단 = "";

            for(int index=0; index <이용자들.Length; index++)
                if (이용자들[index]==null)
                {
                   // 이용자들[index] = 챔피언;
                    break;
                }
            foreach (챔피언 챔피언이름 in 이용자들)
                if (챔피언이름 == null)
                    break;
                else
                    챔피언명단 += 챔피언이름.이름 + ",";
            return 챔피언명단;
        }


    }
}