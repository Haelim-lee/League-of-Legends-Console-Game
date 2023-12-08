using lol.Model;

namespace Lol.Model.Skills
{
    public abstract class SkillBase
    {
        public double AD { get; set; }
        public double AP { get; set; }
        public string SkillName { get; set; }
        public int MP { get; set; }
        public double HP { get; set; }
        public eEvent Event { get; set; } = eEvent.None;

        /// <summary>
        /// 스킬시전
        /// </summary>
        public abstract void UseSkill(Champion target, Champion user);
    } 
}