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
    public class SkillParameter
    {
        /// <summary>
        /// 対応スキル
        /// </summary>
        [SerializeField]
        Skill _skill = default(Skill);
        /// <summary>
        /// 対応スキル
        /// </summary>
        public Skill skill => _skill;

        /// <summary>
        /// スキル値
        /// </summary>
        [SerializeField]
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
