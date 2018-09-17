using Assets.Src.Domain.Model.Value;

namespace Assets.Src.Infrastructure.Repository
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
