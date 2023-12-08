using lol.Model.Skills;
using Lol;
using Lol.Model;
using Lol.Model.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.Model.Champions
{
    public class Garen : Champion
    {
        #region Constructor
        public Garen()
        {
            Name  = "가렌";
            HP  = 620;
            MP = 350;
            AD = 86;
            Defense  = 36;
            EXP = 0;
            Gold = 500;
            APResistance = 20;
            AP = 0;
            Skills = GetSkills();
        }
        #endregion

        #region Functions
        private List<Skill> GetSkills()
        {
            var skills = new List<Skill>();
            skills.Add(new Skill("결정타", AD, AP, MP));
            skills.Add(new Skill("용기", HP, MP));
            skills.Add(new Skill("심판", AD, AP, MP));
            skills.Add(new Skill("데마시아의 정의", AD, AP, MP));

            return skills;
        }
        #endregion
    }
}
