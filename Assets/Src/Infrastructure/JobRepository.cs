using Assets.Src.Models;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// ジョブリポジトリ
    /// </summary>
    public class JobRepository : ResourceRepository<Job>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Job/";
    }
}
