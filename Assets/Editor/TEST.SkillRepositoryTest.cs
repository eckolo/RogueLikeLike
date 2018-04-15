using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models.Value;
using NUnit.Framework;
using System;
using Assets.Src.Infrastructure.Repository;
using UnityEngine;

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
