using Assets.Src.Domains.Models.Interface;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// スキルオブジェクト
    /// </summary>
    [Serializable]
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
        Key _skillKey = default(Key);

        /// <summary>
        /// 内部索引用のキー
        /// </summary>
        public Key key => _skillKey;

        /// <summary>
        /// 内部索引用の値として自身を返す
        /// </summary>
        public Skill value => this;
    }
}
