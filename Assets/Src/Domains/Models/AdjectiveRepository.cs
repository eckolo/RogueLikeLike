using Assets.Src.Infrastructure;

namespace Assets.Src.Domains.Models
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
