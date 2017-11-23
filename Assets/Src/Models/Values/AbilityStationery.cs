using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Values
{
    /// <summary>
    /// アビリティ雛形オブジェクト
    /// </summary>
    public class AbilityStationery : Named
    {
        /// <summary>
        /// ベースとなるスキル値リスト
        /// </summary>
        [SerializeField]
        List<SkillParameter> _baseSkillParameters = new List<SkillParameter>();
        /// <summary>
        /// ベースとなるスキル値リスト
        /// </summary>
        public List<SkillParameter> baseSkillParameterList => _baseSkillParameters;

        /// <summary>
        /// アビリティの性能依存先スキル
        /// </summary>
        [SerializeField]
        List<Parts> _dependentParts = new List<Parts>();
        /// <summary>
        /// アビリティの性能依存先スキルリスト
        /// </summary>
        public List<Parts> dependentPartsList => _dependentParts;

        /// <summary>
        /// 挙動定義リスト
        /// </summary>
        [SerializeField]
        List<Motion> _motionList = new List<Motion>();
        /// <summary>
        /// 挙動定義リスト
        /// </summary>
        public List<Motion> motionList => _motionList;

        /// <summary>
        /// 使用条件ジョブリスト
        /// </summary>
        [SerializeField]
        List<Job> _useablejobs = new List<Job>();
        /// <summary>
        /// 使用条件ジョブリスト
        /// </summary>
        public List<Job> useablejobList => _useablejobs;
    }
}
