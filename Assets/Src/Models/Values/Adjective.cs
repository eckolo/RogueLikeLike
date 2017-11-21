using UnityEngine;
using UnityEditor;

namespace Assets.Src.Models.Values
{
    /// <summary>
    /// 形容詞オブジェクト
    /// </summary>
    public class Adjective : ScriptableObject, INamed
    {
        /// <summary>
        /// 形容詞名称
        /// </summary>
        public new string name => _name;
        /// <summary>
        /// 形容詞名称設定箇所
        /// </summary>
        [SerializeField]
        string _name;

        /// <summary>
        /// 形容詞説明文
        /// </summary>
        public string description => _description;
        /// <summary>
        /// 形容詞説明文章設定箇所
        /// </summary>
        [SerializeField]
        string _description;
    }
}