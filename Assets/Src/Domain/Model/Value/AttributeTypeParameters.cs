using Assets.Src.Domain.Model.Abstract;
using System;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 状態異常に対する数値の疑似辞書型オブジェクト
    /// </summary>
    [Serializable]
    public class AttributeTypeParameters : IKeyValueLike<AttributeType, int>
    {
        /// <summary>
        /// 対応状態異常
        /// </summary>
        [SerializeField]
        AttributeType _key = default(AttributeType);
        /// <summary>
        /// 辞書型変換用プロパティ
        /// </summary>
        public AttributeType key => _key;

        /// <summary>
        /// 状態異常値
        /// </summary>
        [SerializeField]
        [Range(0, 120)]
        int _value = 0;
        /// <summary>
        /// 状態異常値
        /// </summary>
        public int value => _value;
    }
}
