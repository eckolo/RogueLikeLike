using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// NPCオブジェクト
    /// </summary>
    [Serializable]
    public partial class Npc : Adhered<NpcStationery>
    {
        /// <summary>
        /// 各NPCへの友好度
        /// 0より大きければ友好、0未満なら敵対、0丁度なら無関心
        /// </summary>
        public Friendship friendship { get; set; }

        /// <summary>
        /// パラメータ補正値
        /// </summary>
        [SerializeField]
        Parameters _parametersAdjust = Parameters.zero;
        /// <summary>
        /// パラメータ補正値
        /// </summary>
        public Parameters parametersAdjust => _parametersAdjust;

        /// <summary>
        /// 外部から参照されるパラメータ
        /// </summary>
        public virtual Parameters parameters => stationery.parameters + parametersAdjust;

        /// <summary>
        /// 現在HP
        /// </summary>
        public int nowHp
        {
            get { return parameters.nowHp; }
            set { parameters.nowHp = value; }
        }

        /// <summary>
        /// 現在スタミナ
        /// </summary>
        public int nowEnergy
        {
            get { return parameters.nowEnergy; }
            set { parameters.nowEnergy = value; }
        }

        /// <summary>
        /// 現在精神力
        /// </summary>
        public int nowMental
        {
            get { return parameters.nowMental; }
            set { parameters.nowMental = value; }
        }

        /// <summary>
        /// 現在の行動優先度
        /// </summary>
        [SerializeField]
        int _nowInitiative = 0;
        /// <summary>
        /// 現在の行動優先度
        /// </summary>
        public int nowInitiative { get { return _nowInitiative; } set { _nowInitiative = value; } }

        /// <summary>
        /// 状態異常リスト
        /// </summary>
        [SerializeField]
        IEnumerable<StatusAilment> _statusAilmentList = new List<StatusAilment>();
        /// <summary>
        /// 状態異常リスト
        /// </summary>
        public IEnumerable<StatusAilment> statusAilmentList
        {
            get { return _statusAilmentList; }
            set { _statusAilmentList = value; }
        }

        /// <summary>
        /// 行動アルゴリズム
        /// </summary>
        public IEnumerable<ActionTerm> actionAlgorithm => stationery.actionAlgorithm;
    }
}
