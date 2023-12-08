using lol.Model;
using lol.Model.Skills;
using Lol.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.Model.Champions
{
    public class Jhin : Champion
    {
        public Jhin()
        {
            Name = "진";
            HP = 585;
            MP = 300;
            AD = 101;
            Defense = 24;
            EXP = 0;
            Gold = 500;
            APResistance = 14;
            AP = 4;
            Skills = GetSkills();
        }

        private List<Skill> GetSkills()
        {
            var skills = new List<Skill>();

            skills.Add(new Skill("춤추는 유탄", AD, AP, MP));
            skills.Add(new Skill("살상연회", AD, AP, MP));
            skills.Add(new Skill("강제관람", AD, AP, MP, eEvent.Faint));
            skills.Add(new Skill("커튼콜", AD, AP, MP));
            
            return skills;
        }
    }
}
