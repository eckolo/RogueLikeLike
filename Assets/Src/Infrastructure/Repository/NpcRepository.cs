using Assets.Src.Domains.Models.Entity;

namespace Assets.Src.Infrastructure.Repository
{
    /// <summary>
    /// キャラクタリポジトリ
    /// </summary>
    public class NpcRepository : ResourceRepository<Npc.Stationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Person/";
    }
}
