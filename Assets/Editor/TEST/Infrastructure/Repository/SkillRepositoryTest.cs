using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using Assets.Src.Infrastructure.Repository;
using NUnit.Framework;
using System;

namespace TEST.Infrastructure.Repository
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
            foreach(Skill.Key key in Enum.GetValues(typeof(Skill.Key)))
            {
                var skill = skillRepository.GetContests(key);

                Assert.IsNotNull(skill, key.ToFileName());
                Assert.AreEqual(skill.name, key.ToFileName(), key.ToFileName());
                Assert.AreEqual(skill.section, key.ToSection(), key.ToFileName());
                Assert.AreEqual(skill.key, key, key.ToFileName());
            }
        }
    }
}
