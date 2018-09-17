using Assets.Src.Domain.Model.Abstract;
using System;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
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