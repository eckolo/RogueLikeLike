using Assets.Src.Domains;
using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// スキルリポジトリ
    /// </summary>
    public class SkillRepository : ResourceRepository<Skill>, IRepository<Skill, SkillKey>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Skill/";

        public Skill GetContests(SkillKey key) => GetContests(key.ToString());
    }
}
