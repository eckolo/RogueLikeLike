using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    public partial class Npc
    {
        /// <summary>
        /// キャラクター雛形オブジェクト
        /// </summary>
        [Serializable]
        public partial class Stationery : Named
        {
            /// <summary>
            /// 表示画像
            /// </summary>
            [SerializeField]
            Sprite _sprite = default(Sprite);
            /// <summary>
            /// 表示画像
            /// </summary>
            public Sprite displayedSprite => _sprite;

            /// <summary>
            /// 初期スキルリスト
            /// </summary>
            [SerializeField]
            List<Skill.Parameters> _skillParameters = new List<Skill.Parameters>();
            /// <summary>
            /// 外部から参照されるスキルパラメータ
            /// </summary>
            public virtual Npc.Parameters parameters => _skillParameters.ToDictionary().ToParameters();

            /// <summary>
            /// 初期習得済みアビリティリスト
            /// </summary>
            [SerializeField]
            List<Ability.Stationery> _masteredAbilitys = new List<Ability.Stationery>();
            /// <summary>
            /// 習得済みアビリティリスト
            /// </summary>
            public IEnumerable<Ability.Stationery> masteredAbilityList => _masteredAbilitys;

            /// <summary>
            /// 初期所持アイテムリスト
            /// </summary>
            [SerializeField]
            List<Item.Stationery> _possessedItems = new List<Item.Stationery>();
            /// <summary>
            /// 所持アイテムリスト
            /// </summary>
            public IEnumerable<Item.Stationery> possessedItemList => _possessedItems;

            /// <summary>
            /// 所持部位リスト
            /// </summary>
            [SerializeField]
            List<Parts> _possessedParts = new List<Parts>();
            /// <summary>
            /// 所持部位リスト
            /// </summary>
            public IEnumerable<Parts> possessedPartsList => _possessedParts;

            /// <summary>
            /// 習得ジョブリスト
            /// </summary>
            [SerializeField]
            IEnumerable<Job> _hadJobList = new List<Job>();
            /// <summary>
            /// 習得ジョブリスト
            /// </summary>
            public IEnumerable<Job> hadJobList { get { return _hadJobList; } set { _hadJobList = value; } }

            /// <summary>
            /// 行動アルゴリズム
            /// </summary>
            [SerializeField]
            List<ActionTerm> _actionAlgorithm = new List<ActionTerm>();
            /// <summary>
            /// 行動アルゴリズム
            /// </summary>
            public IEnumerable<ActionTerm> actionAlgorithm => _actionAlgorithm;
        }
    }
}
