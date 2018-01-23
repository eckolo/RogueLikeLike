using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// スキルオブジェクト
    /// </summary>
    public partial class Skill : Named, IKeyValueLike<Skill.Key, Skill>
    {
        /// <summary>
        /// スキルの所属する分類項目
        /// </summary>
        [SerializeField]
        Section _section = default(Section);
        /// <summary>
        /// スキルの所属する分類項目
        /// </summary>
        public Section section => _section;

        /// <summary>
        /// 内部索引用のキー
        /// </summary>
        [SerializeField]
        Skill.Key _skillKey = default(Skill.Key);

        /// <summary>
        /// 内部索引用のキー
        /// </summary>
        public Skill.Key key => _skillKey;

        public Skill value => this;
    }
}
