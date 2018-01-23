using System;
using UnityEngine;

namespace Assets.Src.Models
{
    public partial class Skill
    {
        /// <summary>
        /// スキルに対して各エンティティが所持するスキル値のオブジェクト
        /// </summary>
        [Serializable]
        public class Parameters : IKeyValueLike<Skill.Key, int>
        {
            /// <summary>
            /// 対応スキル
            /// </summary>
            [SerializeField]
            Skill.Key _skill = default(Skill.Key);
            /// <summary>
            /// 対応スキル
            /// </summary>
            public Skill.Key skill => _skill;
            /// <summary>
            /// 辞書型変換用プロパティ
            /// </summary>
            public Skill.Key key => skill;

            /// <summary>
            /// スキル値
            /// </summary>
            [SerializeField]
            [Range(0, 120)]
            int _value = 0;
            /// <summary>
            /// スキル値
            /// </summary>
            public int value => _value;
        }
    }
}
