using Assets.Src.Domains.Models.Value;

namespace Assets.Src.Infrastructure.Repository
{
    /// <summary>
    /// 形容詞リポジトリ
    /// </summary>
    public class AdjectiveRepository : ResourceRepository<Adjective>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Adjective/";
    }
}
