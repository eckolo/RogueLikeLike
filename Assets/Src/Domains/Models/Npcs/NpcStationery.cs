using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models.Abilities;
using Assets.Src.Domains.Models.Items;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Npcs
{
    /// <summary>
    /// キャラクター雛形オブジェクト
    /// </summary>
    public partial class NpcStationery : Named
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
        /// スキルリスト
        /// </summary>
        public Dictionary<Skill.Key, int> skillParameters => _skillParameters.ToDictionary();

        /// <summary>
        /// 初期習得済みアビリティリスト
        /// </summary>
        [SerializeField]
        List<AbilityStationery> _masteredAbilitys = new List<AbilityStationery>();
        /// <summary>
        /// 習得済みアビリティリスト
        /// </summary>
        public IEnumerable<AbilityStationery> masteredAbilityList => _masteredAbilitys;

        /// <summary>
        /// 初期所持アイテムリスト
        /// </summary>
        [SerializeField]
        List<ItemStationery> _possessedItems = new List<ItemStationery>();
        /// <summary>
        /// 所持アイテムリスト
        /// </summary>
        public IEnumerable<ItemStationery> possessedItemList => _possessedItems;

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
        /// 状態異常リスト
        /// </summary>
        public IEnumerable<StatusAilment> statusAilmentList { get; protected set; }

        /// <summary>
        /// 習得ジョブリスト
        /// </summary>
        public IEnumerable<Job> hadJobList { get; protected set; }

        /// <summary>
        /// 行動アルゴリズム
        /// </summary>
        [SerializeField]
        List<ActionTerm> _actionAlgorithm = new List<ActionTerm>();
        /// <summary>
        /// 行動アルゴリズム
        /// </summary>
        public IEnumerable<ActionTerm> actionAlgorithm => _actionAlgorithm;

        /// <summary>
        /// 外部から参照されるパラメータ
        /// </summary>
        public virtual Parameters parameters => skillParameters.ToParameters();
    }
}
