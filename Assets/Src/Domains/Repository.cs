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
    /// <typeparam name="Resource">格納されたデータの種別</typeparam>
    abstract class Repository<Resource> where Resource : ScriptableObject
    {
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="name">読み出しデータ名称</param>
        /// <returns>読みだされたデータ</returns>
        abstract public Resource GetResource(string name);
    }
}
