using Assets.Src.Models.Ability;
using Assets.Src.Models.Item;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Person
{
    /// <summary>
    /// キャラクター雛形オブジェクト
    /// </summary>
    public partial class PersonStationery : Named
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
        List<SkillParameter> _skillParameters = new List<SkillParameter>();
        /// <summary>
        /// スキルリスト
        /// </summary>
        public List<SkillParameter> skillParameters => _skillParameters;

        /// <summary>
        /// 初期習得済みアビリティリスト
        /// </summary>
        [SerializeField]
        List<AbilityRoot> _masteredAbilitys = new List<AbilityRoot>();
        /// <summary>
        /// 習得済みアビリティリスト
        /// </summary>
        public List<AbilityRoot> masteredAbilityList => _masteredAbilitys;

        /// <summary>
        /// 初期所持アイテムリスト
        /// </summary>
        [SerializeField]
        List<ItemRoot> _possessedItems = new List<ItemRoot>();
        /// <summary>
        /// 所持アイテムリスト
        /// </summary>
        public List<ItemRoot> possessedItemList => _possessedItems;

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
        public List<Job> hadJobList { get; protected set; }

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
