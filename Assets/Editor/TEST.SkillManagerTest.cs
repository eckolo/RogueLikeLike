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
            var fileName = "DarkAptitude";

            Assert.AreEqual(skillKey.ToFileName(), fileName);
        }
    }
}
