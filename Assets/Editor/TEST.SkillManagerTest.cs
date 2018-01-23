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
            var skillKey1 = Skill.Key.DARK_APTITUDE;
            var skillKey2 = Skill.Key.INDOMITABLE;
            var fileName1 = "20307_DarkAptitude";
            var fileName2 = "00000_Indomitable";

            Assert.AreEqual(skillKey1.ToFileName(), fileName1);
            Assert.AreEqual(skillKey2.ToFileName(), fileName2);
        }

        [Test]
        public static void ToSectionTest()
        {
            var skillKey1 = Skill.Key.LEADER;
            var skillKey2 = Skill.Key.COMMAND;
            var skillKey3 = Skill.Key.DARK_APTITUDE;

            Assert.AreEqual(skillKey1.ToSection(), Skill.Section.SPIRIT);
            Assert.AreEqual(skillKey2.ToSection(), Skill.Section.TECHNIQUE);
            Assert.AreEqual(skillKey3.ToSection(), Skill.Section.BODY);
        }
    }
}
