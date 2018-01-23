using Assets.Src.Models.Abilities;
using Assets.Src.Models.Npcs;
using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// 誰が何のアビリティをどこに向けて使用するのか
    /// </summary>
    public class ActionPattern
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="subject">動作主体</param>
        /// <param name="ability">使用されるアビリティ</param>
        /// <param name="target">アビリティ使用対象座標</param>
        public ActionPattern(Npc subject, Ability ability, Vector2 target)
        {
            _subject = subject;
            _ability = ability;
            _target = target;
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
        /// 使用されるアビリティ
        /// </summary>
        Ability _ability = default(Ability);
        /// <summary>
        /// 使用されるアビリティ
        /// </summary>
        public Ability ability => _ability;

        /// <summary>
        /// 対象座標
        /// </summary>
        Vector2 _target = default(Vector2);

        /// <summary>
        /// 対象座標
        /// </summary>
        public Vector2 target => _target;
    }
}
