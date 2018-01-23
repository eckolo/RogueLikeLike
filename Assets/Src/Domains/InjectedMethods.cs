using Assets.Src.Models;

namespace Assets.Src.Domains
{
    /// <summary>
    /// DI用インターフェース保持クラス
    /// </summary>
    public class InjectedMethods
    {
        /// <summary>
        /// 画面描画処理
        /// </summary>
        public IViewManager viewer { get; set; }
        /// <summary>
        /// スキルリポジトリ
        /// </summary>
        public IRepository<SkillKey, Skill> skillRepository { get; set; }
    }
}
