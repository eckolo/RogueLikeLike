using Assets.Src.Domains;
using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// スキルリポジトリ
    /// </summary>
    public class SkillRepository : ResourceRepository<Skill>, IRepository<SkillKey, Skill>
    {
        /// <summary>
        /// データ格納ディレクトリ
        /// </summary>
        protected override string directory => "Skill/";

        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="name">読み出しデータキー</param>
        /// <returns>読みだされたデータ</returns>
        public Skill GetContests(SkillKey key)
        {
            var fileName = key.ToFileName();
            var result = GetContests(fileName);
            if(result.name != fileName) throw new FileNotFoundException("Skillの索引キーとSkillオブジェクト名が異なる");
            return result;
        }
    }
}
