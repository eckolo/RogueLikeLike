using Assets.Src.Domains;
using Assets.Src.Models.Npcs;

namespace Assets.Src.Models
{
    /// <summary>
    /// キャラクターの動作を示すデータオブジェクト
    /// </summary>
    public abstract class Behavior
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="_subject">動作主体設定値</param>
        public Behavior(Npc _subject)
        {
            this._subject = _subject;
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
        /// <param name="states">動作前のゲーム状態</param>
        /// <returns>動作後のゲーム状態</returns>
        public abstract GameStates Predicate(GameStates states);
    }
}
