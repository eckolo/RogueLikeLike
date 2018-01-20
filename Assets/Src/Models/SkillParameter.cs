using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// スキルに対して各エンティティが所持するスキル値のオブジェクト
    /// </summary>
    [Serializable]
    public class SkillParameter : IKeyValueLike<SkillKey, int>
    {
        /// <summary>
        /// 対応スキル
        /// </summary>
        [SerializeField]
        SkillKey _skill = default(SkillKey);
        /// <summary>
        /// 対応スキル
        /// </summary>
        public SkillKey skill => _skill;
        /// <summary>
        /// 辞書型変換用プロパティ
        /// </summary>
        public SkillKey key => skill;

        /// <summary>
        /// スキル値
        /// </summary>
        [SerializeField]
        [Range(0, 120)]
        int _value = 0;
        /// <summary>
        /// スキル値
        /// </summary>
        public int value
        {
            get {
                return _value;
            }

            set {
                _value = value;
            }
        }
    }
}
