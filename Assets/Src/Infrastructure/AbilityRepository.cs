using Assets.Src.Models.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
