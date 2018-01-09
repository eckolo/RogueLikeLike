using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// 形容詞オブジェクト
    /// </summary>
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