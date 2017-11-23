using Assets.Src.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
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
