using Assets.Src.Domains;
using Assets.Src.Infrastructure;
using Assets.Src.Models;
using NUnit.Framework;
using System;

public static partial class TEST
{
    /// <summary>
    /// スキルリポジトリのテスト
    /// </summary>
    public static class SkillRepositoryTest
    {
        [Test]
        public static void GetContestsTest()
        {
            var skillRepository = new SkillRepository();
            foreach(SkillKey key in Enum.GetValues(typeof(SkillKey)))
            {
                var skill = skillRepository.GetContests(key);

                Assert.IsNotNull(skill);
                Assert.AreEqual(skill.name, key.ToFileName());
                Assert.AreEqual(skill.section, key.ToSection());
                Assert.AreEqual(skill.key, key);
            }
        }
    }
}
