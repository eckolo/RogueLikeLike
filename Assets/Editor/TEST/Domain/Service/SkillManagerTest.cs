using Assets.Src.Domain.Service;
using Assets.Src.Domain.Model.Value;
using NUnit.Framework;

namespace Assets.Editor.TEST.Domain.Service
{
    /// <summary>
    /// スキル関連サービスのテスト
    /// </summary>
    public static class SkillManagerTest
    {
        [Test]
        public static void ToFileNameTest()
        {
            var skillKey1 = Skill.Key.DARK_APTITUDE;
            var skillKey2 = Skill.Key.INDOMITABLE;
            var fileName1 = "20307_DarkAptitude";
            var fileName2 = "00000_Indomitable";

            skillKey1.ToFileName().Is(fileName1);
            skillKey2.ToFileName().Is(fileName2);
        }

        [Test]
        public static void ToSectionTest()
        {
            var skillKey1 = Skill.Key.LEADER;
            var skillKey2 = Skill.Key.COMMAND;
            var skillKey3 = Skill.Key.DARK_APTITUDE;

            skillKey1.ToSection().Is(Skill.Section.SPIRIT);
            skillKey2.ToSection().Is(Skill.Section.TECHNIQUE);
            skillKey3.ToSection().Is(Skill.Section.BODY);
        }
    }
}
