using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// アビリティリポジトリ
    /// </summary>
    public class AbilityRepository : ResourceRepository<AbilityStationery>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Ability/";
    }
}
