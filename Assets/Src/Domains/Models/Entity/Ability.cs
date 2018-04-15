using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// アビリティオブジェクト
    /// </summary>
    [Serializable]
    public class Ability : AbilityStationery, IAdhered
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
    }
}
