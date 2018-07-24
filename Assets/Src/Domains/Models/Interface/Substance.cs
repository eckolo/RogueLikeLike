using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains.Models.Interface
{
    /// <summary>
    /// 雛形をもとに構成されたオブジェクト型
    /// </summary>
    /// <typeparam name="TStationery">雛形の型</typeparam>
    public abstract class Substance<TStationery> where TStationery : Named
    {
        /// <summary>
        /// 雛形情報
        /// </summary>
        [SerializeField]
        TStationery _stationery = null;
        /// <summary>
        /// 雛形情報
        /// </summary>
        protected TStationery stationery => _stationery;

        /// <summary>
        /// オブジェクト名
        /// </summary>
        public string name => stationery?.name ?? "";
    }
}