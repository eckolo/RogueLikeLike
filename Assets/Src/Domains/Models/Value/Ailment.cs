using Assets.Src.Domains.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 状態オブジェクト
    /// </summary>
    public partial class Ailment : Substance<Ailment.Stationery>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stationery">元となる雛形</param>
        public Ailment(Stationery stationery) : base(stationery)
        {
        }
    }
}
