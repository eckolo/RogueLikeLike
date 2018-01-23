using Assets.Src.Models.Areas;

namespace Assets.Src.Infrastructure
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
