using lol.Helper;
using Lol.Locations;
using Lol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.Object
{
    public class RespawnArea : Location
    {
        public override void Attack(Champion champion)
        {
            SpeakHelper.CreateWord($"{champion.Name}이 {Name}에게 " +
                $"{champion.AD}의 공격을 가했습니다.");

            SpeakHelper.CreateWord($"{Name}  HP  : {HP}");
        }
    }
}
