using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// アイテムオブジェクト
    /// </summary>
    [Serializable]
    public partial class Item : Adhered<ItemStationery>
    {
    }
}
