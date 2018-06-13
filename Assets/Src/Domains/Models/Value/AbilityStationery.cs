using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// アビリティ雛形オブジェクト
    /// </summary>
    [Serializable]
    public partial class AbilityStationery : Named
    {
        /// <summary>
        /// アビリティ性能判定スキル一覧
        /// </summary>
        [SerializeField]
        List<Skill.Parameters> _baseSkillParameters = new List<Skill.Parameters>();
        /// <summary>
        /// アビリティ性能判定スキル一覧
        /// </summary>
        public Dictionary<Skill.Key, int> baseSkillParameterList => _baseSkillParameters.ToDictionary();

        /// <summary>
        /// アビリティの使用可否依存先部位
        /// </summary>
        [SerializeField]
        List<Parts> _dependentParts = new List<Parts>();
        /// <summary>
        /// アビリティの使用可否依存先部位
        /// </summary>
        public IEnumerable<Parts> dependentPartsList => _dependentParts;

        /// <summary>
        /// 使用条件ジョブリスト
        /// </summary>
        [SerializeField]
        List<Job> _useablejobs = new List<Job>();
        /// <summary>
        /// 使用条件ジョブリスト
        /// </summary>
        public IEnumerable<Job> useablejobList => _useablejobs;

        /// <summary>
        /// 移動可能範囲
        /// </summary>
        [SerializeField]
        List<PointRadius> _movement = new List<PointRadius>();
        /// <summary>
        /// 移動可能範囲
        /// </summary>
        public Coverage movement => new Coverage(_movement);

        /// <summary>
        /// 移動時表示エフェクト情報
        /// </summary>
        [SerializeField]
        EffectAnimation _moveAnimation;
        /// <summary>
        /// 移動時表示エフェクト情報
        /// </summary>
        public EffectAnimation moveAnimation => _moveAnimation;

        /// <summary>
        /// 挙動定義リスト
        /// </summary>
        [SerializeField]
        List<Behavior> _behaviorDefinition = new List<Behavior>();
        /// <summary>
        /// 挙動定義リスト
        /// </summary>
        public List<Behavior> behaviorList => _behaviorDefinition;
    }
}
