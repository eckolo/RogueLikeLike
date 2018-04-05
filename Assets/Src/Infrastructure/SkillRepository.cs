using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models;

namespace Assets.Src.Infrastructure
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
