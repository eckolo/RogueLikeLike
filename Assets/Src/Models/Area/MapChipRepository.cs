using Assets.Src.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models.Area
{
    /// <summary>
    /// マップチップリポジトリ
    /// </summary>
    public class MapChipRepository : ResourceRepository<MapChip>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "MapChip/";
    }
}
