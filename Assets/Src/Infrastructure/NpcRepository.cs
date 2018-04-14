using Assets.Src.Domains.Models;

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
