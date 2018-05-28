using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 具体的な動作内容を示すデータ群
    /// </summary>
    [Serializable]
    public partial class Behavior
    {
        /// <summary>
        /// 威力値への動作主体ステータス反映度（％）
        /// </summary>
        [SerializeField]
        Npc.Parameters _powerParameters = null;
        /// <summary>
        /// 威力値への動作主体ステータス反映度（％）
        /// </summary>
        public Npc.Parameters powerParameters => _powerParameters;
        /// <summary>
        /// 精度への動作主体ステータス反映度（％）
        /// </summary>
        [SerializeField]
        Npc.Parameters _accuracyParameters = null;
        /// <summary>
        /// 精度への動作主体ステータス反映度（％）
        /// </summary>
        public Npc.Parameters accuracyParameters => _accuracyParameters;

        /// <summary>
        /// 威力値への動作対象ステータス反映度（％）
        /// </summary>
        [SerializeField]
        Npc.Parameters _targetPowerParameters = null;
        /// <summary>
        /// 威力値への動作対象ステータス反映度（％）
        /// </summary>
        public Npc.Parameters targetPowerParameters => _targetPowerParameters;
        /// <summary>
        /// 精度への動作対象ステータス反映度（％）
        /// </summary>
        [SerializeField]
        Npc.Parameters _targetAccuracyParameters = null;
        /// <summary>
        /// 精度への動作対象ステータス反映度（％）
        /// </summary>
        public Npc.Parameters targetAccuracyParameters => _targetAccuracyParameters;

        /// <summary>
        /// 対象範囲
        /// </summary>
        [SerializeField]
        List<PointRadius> _coverage = new List<PointRadius>();
        /// <summary>
        /// 対象範囲
        /// </summary>
        public Coverage coverage => new Coverage(_coverage);

        /// <summary>
        /// 吹き飛ばし方向・量
        /// </summary>
        [SerializeField, Tooltip("離れるなら正の値、引き寄せは負の値")]
        int _blowing = 0;
        /// <summary>
        /// 吹き飛ばし方向・量
        /// </summary>
        public int blowing => _blowing;

        /// <summary>
        /// ターゲットタイプ
        /// </summary>
        [SerializeField]
        TargetType _targetType = default(TargetType);
        /// <summary>
        /// ターゲットタイプ
        /// </summary>
        public TargetType targetType => _targetType;

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
        /// 属性毎のモーション威力値
        /// </summary>
        [SerializeField]
        List<AttributeTypeParameters> _powers = new List<AttributeTypeParameters>();
        /// <summary>
        /// 属性毎のモーション威力値
        /// </summary>
        public List<AttributeTypeParameters> powers => _powers;

        /// <summary>
        /// モーション精度
        /// </summary>
        [SerializeField]
        uint _accuracy = 0;
        /// <summary>
        /// モーション精度
        /// </summary>
        public int accuracy => (int)_accuracy;

        /// <summary>
        /// 状態異常付与量
        /// </summary>
        [SerializeField]
        List<StatusAilment.Parameters> _ailments;
        /// <summary>
        /// 状態異常付与量（レベル）
        /// </summary>
        public Dictionary<StatusAilment, int> ailmentAmount => _ailments.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Key);
        /// <summary>
        /// 状態異常延長ターン数
        /// </summary>
        public Dictionary<StatusAilment, int> ailmentDuration => _ailments.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Value);
    }
}
