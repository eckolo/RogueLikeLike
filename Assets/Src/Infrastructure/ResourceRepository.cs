using Assets.Src.Domains.Service;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// Resourceからの読み出し処理ラッパー
    /// </summary>
    /// <typeparam name="Resource">読みだされるソースオブジェクト型</typeparam>
    public abstract class ResourceRepository<Resource> : IRepository<string, Resource> where Resource : ScriptableObject
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected abstract string directory { get; }
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="name">読み出しデータ名称</param>
        /// <returns>読みだされたデータ</returns>
        public Resource GetContests(string name) => Resources.Load<Resource>($"{directory}{name}");
    }
}
