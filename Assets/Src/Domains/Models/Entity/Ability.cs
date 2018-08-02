using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// アビリティオブジェクト
    /// </summary>
    [Serializable]
    public partial class Ability : Adhered<AbilityStationery>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stationery">元となる雛形</param>
        /// <param name="adjectives">付与形容詞</param>
        public Ability(AbilityStationery stationery, List<Adjective> adjectives = null) : base(stationery, adjectives)
        {
        }

        /// <summary>
        /// 挙動定義リスト
        /// </summary>
        public List<Behavior> behaviorList => stationery.behaviorList;

        /// <summary>
        /// 移動時表示エフェクト情報
        /// </summary>
        public List<EffectAnimation> moveAnimations => stationery.moveAnimations;
    }
}
