using Assets.Src.Domains.Models.Interface;
using System;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// アビリティオブジェクト
    /// </summary>
    [Serializable]
    public partial class Ability : Adhered<Ability.Stationery>
    {
    }
}
