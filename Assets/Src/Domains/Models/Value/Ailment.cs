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
    public partial class Ailment
    {
        /// <summary>
        /// 状態情報雛形
        /// </summary>
        [SerializeField]
        Stationery _stationery = null;
        /// <summary>
        /// 状態情報雛形
        /// </summary>
        public Stationery stationery => _stationery;
    }
}
