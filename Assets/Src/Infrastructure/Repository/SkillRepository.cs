using Assets.Src.Domain.Service;
using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Repository;

namespace Assets.Src.Infrastructure.Repository
{
    /// <summary>
    /// スキルリポジトリ
    /// </summary>
    public class SkillRepository : ResourceRepository<Skill>, IRepository<Skill.Key, Skill>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Skill/";

        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="key">読み出しデータキー</param>
        /// <returns>読みだされたデータ</returns>
        public Skill GetContests(Skill.Key key) => GetContests(key.ToFileName());
    }
}
