using Assets.Src.Domains.Models.Entity;

namespace Assets.Src.Infrastructure.Repository
{
    /// <summary>
    /// アビリティリポジトリ
    /// </summary>
    public class AbilityRepository : ResourceRepository<Ability.Stationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Ability/";
    }
}
