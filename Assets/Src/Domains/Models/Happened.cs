using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models.Abilities;
using Assets.Src.Domains.Models.Npcs;

namespace Assets.Src.Domains.Models
{
    /// <summary>
    /// キャラクターの動作の結果発生した事象を表すデータクラス
    /// </summary>
    public abstract class Happened
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="subject">動作主体設定値</param>
        /// <param name="predicate">動作内容</param>
        public Happened(Npc subject, Behavior predicate)
        {
            _subject = subject;
            _predicate = predicate;
        }

        /// <summary>
        /// 動作主体
        /// </summary>
        Npc _subject;
        /// <summary>
        /// 動作主体
        /// </summary>
        public Npc subject => _subject;

        /// <summary>
        /// 動作内容
        /// </summary>
        public Behavior _predicate;
        /// <summary>
        /// 動作内容
        /// </summary>
        public Behavior predicate => _predicate;

        /// <summary>
        /// 動作内容
        /// </summary>
        /// <param name="states">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public abstract IGameStates Predicate(IGameStates states);
    }
}
