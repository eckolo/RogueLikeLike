using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// アイテムオブジェクト
    /// </summary>
    [Serializable]
    public class Item : Adhered<ItemStationery>
    {
    }
}
