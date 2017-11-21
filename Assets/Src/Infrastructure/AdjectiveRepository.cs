using Assets.Src.Models.Values;
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
    class AdjectiveRepository : ResourceRepository<Adjective>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Adjective/";
    }
}
