using Assets.Src.Domains.Models.Abstract;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 形容詞オブジェクト
    /// </summary>
    [Serializable]
    public class Adjective : Named
    {
        /// <summary>
        /// 接頭辞としての名称
        /// </summary>
        [SerializeField]
        string _prefixName = null;
        /// <summary>
        /// 接頭辞としての名称
        /// </summary>
        public string prefixName => _prefixName;
    }
}