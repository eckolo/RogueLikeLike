using Assets.Src.Domain.Model.Value;

namespace Assets.Src.Infrastructure.Repository
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
