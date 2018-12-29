using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using Assets.Src.Infrastructure.Repository;
using NUnit.Framework;
using System;

namespace Assets.Editor.TEST.Infrastructure.Repository
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

                skill.IsNotNull();
                skill.name.Is(key.ToFileName());
                skill.section.Is(key.ToSection());
                skill.key.Is(key);
            }
        }
    }
}
