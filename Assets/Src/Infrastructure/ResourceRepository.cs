using Assets.Src.Domains;
using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// Resourceからの読み出し処理ラッパー
    /// </summary>
    /// <typeparam name="Resource"></typeparam>
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
