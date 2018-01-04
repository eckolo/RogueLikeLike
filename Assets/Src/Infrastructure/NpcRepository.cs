using Assets.Src.Models.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// キャラクタリポジトリ
    /// </summary>
    public class NpcRepository : ResourceRepository<NpcStationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Person/";
    }
}
