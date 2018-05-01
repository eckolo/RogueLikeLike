using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Interface
{
    /// <summary>
    /// 形容されたオブジェクトの雛形
    /// </summary>
    public abstract class Adhered<TStationery> where TStationery : Named
    {
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

        /// <summary>
        /// 雛形情報
        /// </summary>
        [SerializeField]
        TStationery _stationery;
        /// <summary>
        /// 雛形情報
        /// </summary>
        public TStationery stationery => _stationery;
    }
}
