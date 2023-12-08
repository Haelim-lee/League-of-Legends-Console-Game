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
    public class Leona : Champion
    {
        public Leona()
        {
            Name = "레오나";
            HP = 585.16;
            MP = 302;
            AD = 60;
            Defense = 47;
            EXP = 0;
            Gold = 500;
            APResistance = 20;
            AP = 5;
            Skills = GetSkills();
        }

        private List<Skill> GetSkills()
        {
            var skills = new List<Skill>();

            skills.Add(new Skill("여명의 방패", AD, AP, MP, eEvent.Faint));
            skills.Add(new Skill("일식", HP, MP));
            skills.Add(new Skill("일식", AD, AP, MP, eEvent.Faint));
            skills.Add(new Skill("흑검폭팔", AD, AP, MP, eEvent.Faint));

            return skills;
        }
    }
}
