using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Infrastructure.Repository
{
    /// <summary>
    /// <see cref="AreaStationery"/>リポジトリ
    /// </summary>
    public class AreaRepository : ResourceRepository<AreaStationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Area/";
    }
}
