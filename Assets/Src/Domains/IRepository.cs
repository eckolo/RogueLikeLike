using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains
{
    /// <summary>
    /// データ格納リポジトリの雛形
    /// </summary>
    /// <typeparam name="Contests">格納されたデータの種別</typeparam>
    public interface IRepository<Contests, Key> where Contests : ScriptableObject
    {
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="name">読み出しデータキー</param>
        /// <returns>読みだされたデータ</returns>
        Contests GetResource(Key key);
    }
}
