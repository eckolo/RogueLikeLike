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
    class SkillRepository : MonoBehaviour, IRepository<Skill, int>
    {
        /// <summary>
        /// 格納データ読み出し関数
        /// </summary>
        /// <param name="key">読み出しデータキー</param>
        /// <returns>読みだされたデータ</returns>
        public Skill GetResource(int key)
        {
            if(key < 0) throw new IndexOutOfRangeException();
            if(key > _allSkillList.Count) throw new IndexOutOfRangeException();
            return _allSkillList[key];
        }

        /// <summary>
        /// 全スキルリスト
        /// </summary>
        [SerializeField]
        List<Skill> _allSkillList = new List<Skill>();
    }
}
