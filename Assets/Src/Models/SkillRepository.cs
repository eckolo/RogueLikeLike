using Assets.Src.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models
{
    /// <summary>
    /// スキルリポジトリ
    /// </summary>
    public class SkillRepository : MonoBehaviour, IRepository<Skill, int>
    {
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="key">読み出しデータキー</param>
        /// <returns>読みだされたデータ</returns>
        public Skill GetContests(int key)
        {
            if(key < 0) return default(Skill);
            if(key > _allSkillList.Count) return default(Skill);
            return _allSkillList[key];
        }

        /// <summary>
        /// 全スキルリスト
        /// </summary>
        [SerializeField]
        List<Skill> _allSkillList = new List<Skill>();
    }
}
