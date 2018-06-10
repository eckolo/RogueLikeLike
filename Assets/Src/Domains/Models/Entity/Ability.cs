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
        /// 挙動定義リスト
        /// </summary>
        public List<Behavior> behaviorList => stationery.behaviorList;
    }
}
