using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Infrastructure.Repository
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
