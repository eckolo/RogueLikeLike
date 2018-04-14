using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models
{
    /// <summary>
    /// アビリティの具体的動作を示すデータ群
    /// </summary>
    [Serializable]
    public partial class Behavior
    {
        /// <summary>
        /// 同時発生エフェクト一覧
        /// </summary>
        [SerializeField]
        List<EffectAnimation> _effects = new List<EffectAnimation>();
        /// <summary>
        /// 同時発生エフェクト一覧
        /// </summary>
        public IEnumerable<EffectAnimation> effectList => _effects;

        /// <summary>
        /// 付随属性
        /// </summary>
        [SerializeField]
        AttributeType _attributeType = default(AttributeType);
        /// <summary>
        /// 付随属性
        /// </summary>
        public AttributeType? attributeType => _attributeType;

        /// <summary>
        /// モーション威力
        /// </summary>
        [SerializeField]
        uint _power = 0;
        /// <summary>
        /// モーション威力
        /// </summary>
        public uint power => _power;

        /// <summary>
        /// モーション精度
        /// </summary>
        [SerializeField]
        uint _accuracy = 0;
        /// <summary>
        /// モーション精度
        /// </summary>
        public uint accuracy => _accuracy;
    }
}
