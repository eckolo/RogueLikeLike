using Assets.Src.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// 形容詞リポジトリ
    /// </summary>
    public class AdjectiveRepository : ResourceRepository<Adjective>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Adjective/";
    }
}
