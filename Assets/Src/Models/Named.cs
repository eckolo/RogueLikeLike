using UnityEngine;
using UnityEditor;

namespace Assets.Src.Models
{
    /// <summary>
    /// 名前付きオブジェクトの雛形
    /// </summary>
    public abstract class Named : ScriptableObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        public new string name => _name;
        /// <summary>
        /// 名称設定箇所
        /// </summary>
        [SerializeField]
        string _name;

        /// <summary>
        /// 説明
        /// </summary>
        public string description => _description;
        /// <summary>
        /// 説明文章設定箇所
        /// </summary>
        [SerializeField]
        string _description;
    }
}