using UnityEngine;
using UnityEditor;

namespace Assets.Src.Models
{
    /// <summary>
    /// 名前付きオブジェクトの雛形
    /// </summary>
    public interface INamed
    {
        /// <summary>
        /// 名前
        /// </summary>
        string name { get; }
        /// <summary>
        /// 説明
        /// </summary>
        string description { get; }
    }
}