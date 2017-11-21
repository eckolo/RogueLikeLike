using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Value
{
    /// <summary>
    /// スキルオブジェクト
    /// </summary>
    class Skill : ScriptableObject, INamed
    {
        /// <summary>
        /// スキル名称
        /// </summary>
        public new string name => _name;
        /// <summary>
        /// スキル名称設定箇所
        /// </summary>
        [SerializeField]
        string _name;

        /// <summary>
        /// スキル説明文
        /// </summary>
        public string description => _description;
        /// <summary>
        /// スキル説明文章設定箇所
        /// </summary>
        [SerializeField]
        string _description;
    }
}
