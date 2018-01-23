using Assets.Src.Domains;
using Assets.Src.Models;
using NUnit.Framework;

public static partial class TEST
{
    /// <summary>
    /// スキル関連サービスのテスト
    /// </summary>
    public static class SkillManagerTest
    {
        [Test]
        public static void ToFileNameTest()
        {
            var skillKey = SkillKey.DARK_APTITUDE;
            var fileName = "20307_DarkAptitude";

            Assert.AreEqual(skillKey.ToFileName(), fileName);
        }

        [Test]
        public static void ToSectionTest()
        {
            var skillKey1 = SkillKey.LEADER;
            var skillKey2 = SkillKey.COMMAND;
            var skillKey3 = SkillKey.DARK_APTITUDE;

            Assert.AreEqual(skillKey1.ToSection(), Skill.Section.SPIRIT);
            Assert.AreEqual(skillKey2.ToSection(), Skill.Section.TECHNIQUE);
            Assert.AreEqual(skillKey3.ToSection(), Skill.Section.BODY);
        }
    }
}
