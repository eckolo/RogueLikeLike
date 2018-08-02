using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Interface
{
    /// <summary>
    /// 形容されたオブジェクトの雛形
    /// </summary>
    /// <typeparam name="TStationery">形容対象の型</typeparam>
    public abstract class Adhered<TStationery> : Substance<TStationery> where TStationery : Named
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="stationery">元となる雛形</param>
        /// <param name="adjectives">付与形容詞</param>
        public Adhered(TStationery stationery, List<Adjective> adjectives = null) : base(stationery)
        {
            _adjectives = adjectives ?? new List<Adjective>();
        }

        /// <summary>
        /// 形容詞リスト
        /// </summary>
        [SerializeField]
        List<Adjective> _adjectives = new List<Adjective>();

        /// <summary>
        /// 形容詞リスト
        /// </summary>
        public List<Adjective> adjectives { get { return _adjectives; } set { _adjectives = value; } }

        /// <summary>
        /// 主要形容詞
        /// </summary>
        public Adjective mainAdjective => adjectives.First();
    }
}
