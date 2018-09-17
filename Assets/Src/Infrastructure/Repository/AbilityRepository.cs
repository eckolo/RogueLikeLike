using Assets.Src.Domain.Model.Value;

namespace Assets.Src.Infrastructure.Repository
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
