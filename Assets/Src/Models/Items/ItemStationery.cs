using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Items
{
    /// <summary>
    /// アイテムの雛形オブジェクト
    /// </summary>
    public class ItemStationery : Named
    {
        /// <summary>
        /// 装備可能部位
        /// </summary>
        [SerializeField]
        List<Parts> _equipableParts = new List<Parts>();
        /// <summary>
        /// 装備可能部位リスト
        /// </summary>
        public virtual IEnumerable<Parts> equipablePartsList => _equipableParts;

        /// <summary>
        /// 装備可能ジョブ
        /// </summary>
        [SerializeField]
        List<Job> _equipableJobs = new List<Job>();
        /// <summary>
        /// 装備可能ジョブリスト
        /// </summary>
        public virtual IEnumerable<Job> equipableJobList => _equipableJobs;
    }
}
