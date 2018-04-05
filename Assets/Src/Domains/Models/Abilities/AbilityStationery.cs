using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Abilities
{
    /// <summary>
    /// アビリティ雛形オブジェクト
    /// </summary>
    public partial class AbilityStationery : Named
    {
        /// <summary>
        /// ベースとなるスキル値リスト
        /// </summary>
        [SerializeField]
        List<Skill.Parameters> _baseSkillParameters = new List<Skill.Parameters>();
        /// <summary>
        /// ベースとなるスキル値リスト
        /// </summary>
        public IEnumerable<Skill.Parameters> baseSkillParameterList => _baseSkillParameters;

        /// <summary>
        /// アビリティの性能依存先スキル
        /// </summary>
        [SerializeField]
        List<Parts> _dependentParts = new List<Parts>();
        /// <summary>
        /// アビリティの性能依存先スキルリスト
        /// </summary>
        public IEnumerable<Parts> dependentPartsList => _dependentParts;

        /// <summary>
        /// 挙動定義リスト
        /// </summary>
        public List<Behavior> behaviorList => _behaviorDefinition.behaviorList;

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
        /// 挙動定義パラメータ
        /// </summary>
        [SerializeField]
        Behavior.Definition _behaviorDefinition = new Behavior.Definition();
    }
}
