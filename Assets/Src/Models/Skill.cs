using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// スキルオブジェクト
    /// </summary>
    public partial class Skill : Named, IKeyValueLike<SkillKey, Skill>
    {
        /// <summary>
        /// スキルの所属する分類項目
        /// </summary>
        [SerializeField]
        Section _section = default(Section);

        /// <summary>
        /// 分類項目内のインデックス番号
        /// </summary>
        [SerializeField]
        uint _index = 0;

        /// <summary>
        /// 内部索引用のキー
        /// </summary>
        [SerializeField]
        SkillKey _skillKey = default(SkillKey);

        /// <summary>
        /// 内部索引用のキー
        /// </summary>
        public SkillKey key => _skillKey;

        public Skill value => this;
    }
}
