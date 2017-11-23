using Assets.Src.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Values
{
    /// <summary>
    /// キャラクター雛形オブジェクト
    /// </summary>
    public class PersonStationery : Named
    {
        /// <summary>
        /// 初期スキルリスト
        /// </summary>
        [SerializeField]
        List<SkillParameter> _skillParameters = new List<SkillParameter>();
        /// <summary>
        /// スキルリスト
        /// </summary>
        public List<SkillParameter> skillParameters => _skillParameters;

        /// <summary>
        /// 初期習得済みアビリティリスト
        /// </summary>
        [SerializeField]
        List<Ability> _masteredAbilitys = new List<Ability>();
        /// <summary>
        /// 習得済みアビリティリスト
        /// </summary>
        public List<Ability> masteredAbilityList => _masteredAbilitys;

        /// <summary>
        /// 初期所持アイテムリスト
        /// </summary>
        [SerializeField]
        List<Item> _possessedItems = new List<Item>();
        /// <summary>
        /// 所持アイテムリスト
        /// </summary>
        public List<Item> possessedItemList => _possessedItems;

        /// <summary>
        /// 所持部位リスト
        /// </summary>
        [SerializeField]
        List<Parts> _possessedParts = new List<Parts>();
        /// <summary>
        /// 所持部位リスト
        /// </summary>
        public List<Parts> possessedPartsList => _possessedParts;

        /// <summary>
        /// 状態異常リスト
        /// </summary>
        public List<StatusAilment> statusAilmentList { get; protected set; }

        /// <summary>
        /// 習得ジョブリスト
        /// </summary>
        public List<Job> hadJobList { get; }

        /// <summary>
        /// 行動アルゴリズム
        /// </summary>
        List<ActionTerm> _actionAlgorithm = new List<ActionTerm>();
        /// <summary>
        /// 行動アルゴリズム
        /// </summary>
        public List<ActionTerm> actionAlgorithm => _actionAlgorithm;
    }
}
