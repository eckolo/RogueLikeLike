﻿using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Abstract;
using Assets.Src.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// キャラクター雛形オブジェクト
    /// </summary>
    [Serializable]
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
        /// 外部から参照されるスキルパラメータ
        /// </summary>
        public virtual Npc.Parameters parameters => _skillParameters.ToDictionary().ToParameters();

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
        /// 習得ジョブリスト
        /// </summary>
        [SerializeField]
        IEnumerable<Job> _hadJobList = Enumerable.Empty<Job>();
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