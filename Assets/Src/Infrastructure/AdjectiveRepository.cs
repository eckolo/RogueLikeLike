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
    /// 形容詞リポジトリ
    /// </summary>
    class AdjectiveRepository : Repository<Adjective>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        const string DIRECTORY = "Adjective/";
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="name">読み出しデータ名称</param>
        /// <returns>読みだされたデータ</returns>
        public override Adjective GetResource(string name) => Resources.Load<Adjective>($"{DIRECTORY}{name}");
    }
}
