using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// アビリティの具体的動作を示すデータ群
    /// </summary>
    [Serializable]
    public partial class Behavior
    {
        /// <summary>
        /// 移動可能範囲
        /// </summary>
        [SerializeField]
        SpecifiedRange _movement = SpecifiedRange.zero;
        /// <summary>
        /// 移動可能範囲
        /// </summary>
        public SpecifiedRange movement => _movement;

        /// <summary>
        /// 対象範囲
        /// </summary>
        [SerializeField]
        SpecifiedRange _coverage = SpecifiedRange.zero;
        /// <summary>
        /// 対象範囲
        /// </summary>
        public SpecifiedRange coverage => _coverage;

        /// <summary>
        /// ターゲットタイプ
        /// </summary>
        [SerializeField]
        TargetableType _targetableType = default(TargetableType);
        /// <summary>
        /// ターゲットタイプ
        /// </summary>
        public TargetableType targetableType => _targetableType;

        /// <summary>
        /// 影響を受けるスキルと影響度合い一覧
        /// </summary>
        [SerializeField]
        List<Skill.Parameters> _affectedSkills = new List<Skill.Parameters>();
        /// <summary>
        /// 影響を受けるスキルと影響度合いリスト
        /// </summary>
        public Dictionary<Skill.Key, int> affectedSkills => _affectedSkills.ToDictionary();
        /// <summary>
        /// 同時発生エフェクト一覧
        /// </summary>
        [SerializeField]
        List<EffectAnimation> _effects = new List<EffectAnimation>();
        /// <summary>
        /// 同時発生エフェクト一覧
        /// </summary>
        public IEnumerable<EffectAnimation> effects => _effects;

        /// <summary>
        /// 付随属性リスト
        /// </summary>
        [SerializeField]
        List<AttributeType> _attributeTypes = new List<AttributeType>();
        /// <summary>
        /// 付随属性リスト
        /// </summary>
        public List<AttributeType> attributeTypes => _attributeTypes;

        /// <summary>
        /// モーション威力
        /// </summary>
        [SerializeField]
        uint _power = 0;
        /// <summary>
        /// モーション威力
        /// </summary>
        public int power => (int)_power;

        /// <summary>
        /// モーション精度
        /// </summary>
        [SerializeField]
        uint _accuracy = 0;
        /// <summary>
        /// モーション精度
        /// </summary>
        public int accuracy => (int)_accuracy;
    }
}
