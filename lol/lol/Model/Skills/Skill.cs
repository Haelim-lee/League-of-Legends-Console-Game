using lol.Helper;
using Lol;
using Lol.Model;
using Lol.Model.Skills;
using System.Threading;

namespace lol.Model.Skills
{
    public class Skill : SkillBase
    {
        public Skill(string name, double ad,
            double ap, int mp, eEvent skillEvent = eEvent.None)
        {
            AD = ad;
            AP = ap;
            MP = mp;
            SkillName = name;
            Event = skillEvent;
        }

        public Skill(string name, double hp, 
            int mp, eEvent skillEvent = eEvent.None)
        {
            HP = hp;
            MP = mp;
            SkillName = name;
            Event = skillEvent;
        }

        public override void UseSkill(Champion target, Champion user)
        {
            var damage = AD + AP;

            target.HP -= damage;
            user.MP -= MP;

            if (HP > 0)
            {
                user.HP += HP;
                SpeakHelper.CreateWord(user.Name + "의 체력이"
                    + HP.ToString() + "만큼 회복했습니다.");
            }
            else if (AD > 0 || AP > 0)
                SpeakHelper.CreateWord(target.Name + "에게" 
                    + damage.ToString() + "의 피해를 가했습니다.");

            else if (Event == eEvent.Airborne)
            {
                SpeakHelper.CreateWord(target.Name + "이 공중에 띄워졌습니다.");
                Thread.Sleep(200);
            }
            else if (Event == eEvent.Faint)
            {
                SpeakHelper.CreateWord(target.Name + "이 기절하였습니다.");
                Thread.Sleep(200);
            }

            SpeakHelper.CreateWord(target.Name + " HP :" + target.HP.ToString());
            SpeakHelper.CreateWord(user.Name + "의 MP :" + user.MP.ToString());
        }
    }
}
