using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 具体的な動作内容を示すデータ群
    /// </summary>
    [Serializable]
    public partial class Behavior
    {
        /// <summary>
        /// 威力基準値
        /// </summary>
        [SerializeField]
        int _power = -1;
        /// <summary>
        /// 威力基準値
        /// </summary>
        public int power => _power;

        /// <summary>
        /// 威力値への動作主体ステータス反映度（％）
        /// </summary>
        [SerializeField]
        List<ParametersSet> _attackParameters = null;
        /// <summary>
        /// 威力値への動作主体ステータス反映度（％）
        /// </summary>
        public Dictionary<ParameterType, Npc.Parameters> attackParameters => _attackParameters.ToDictionary();
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
        List<ParametersSet> _defenseParameters = null;
        /// <summary>
        /// 威力値への動作対象ステータス反映度（％）
        /// </summary>
        public Dictionary<ParameterType, Npc.Parameters> defenseParameters => _defenseParameters.ToDictionary();
        /// <summary>
        /// 精度への動作対象ステータス反映度（％）
        /// </summary>
        [SerializeField]
        Npc.Parameters _evasionParameters = null;
        /// <summary>
        /// 精度への動作対象ステータス反映度（％）
        /// </summary>
        public Npc.Parameters evasionParameters => _evasionParameters;

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
        List<EffectAnimation> _animations = new List<EffectAnimation>();
        /// <summary>
        /// 同時発生エフェクト一覧
        /// </summary>
        public List<EffectAnimation> animations => _animations;

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
        List<Ailment.Parameters> _ailments = new List<Ailment.Parameters>();
        /// <summary>
        /// 状態異常付与量（レベル）
        /// </summary>
        public Dictionary<Ailment, int> ailmentAmount => _ailments.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Key);
        /// <summary>
        /// 状態異常延長ターン数
        /// </summary>
        public Dictionary<Ailment, int> ailmentDuration => _ailments.ToDictionary()
            .ToDictionary(ailment => ailment.Key, ailment => ailment.Value.Value);
    }
}