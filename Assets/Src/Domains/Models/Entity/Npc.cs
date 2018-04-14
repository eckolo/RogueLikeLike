using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// NPCオブジェクト
    /// </summary>
    public class Npc : NpcStationery, IAdhered
    {
        /// <summary>
        /// 形容詞リスト
        /// </summary>
        public List<Adjective> adjectives { get; set; }

        /// <summary>
        /// 主要形容詞
        /// </summary>
        public Adjective mainAdjective => adjectives.First();

        /// <summary>
        /// 現存在座標
        /// </summary>
        Vector2 _location = Vector2.zero;
        /// <summary>
        /// 現存在座標
        /// </summary>
        public Vector2 location => _location;

        /// <summary>
        /// パラメータ補正値
        /// </summary>
        Parameters _parametersAdjust = null;
        /// <summary>
        /// パラメータ補正値
        /// </summary>
        public Parameters parametersAdjust => _parametersAdjust;

        /// <summary>
        /// 外部から参照されるパラメータ
        /// </summary>
        public override Parameters parameters => base.parameters + parametersAdjust;

        /// <summary>
        /// 現在HP
        /// </summary>
        int? _nowHp = null;
        /// <summary>
        /// 現在HP
        /// </summary>
        public int nowHp
        {
            get {
                int result = _nowHp ?? parameters.maxHp;
                _nowHp = result;
                return result;
            }
            set {
                _nowHp = Mathf.Min(value, parameters.maxHp);
            }
        }

        /// <summary>
        /// 現在スタミナ
        /// </summary>
        int? _nowEnergy = null;
        /// <summary>
        /// 現在スタミナ
        /// </summary>
        public int nowEnergy
        {
            get {
                int result = _nowEnergy ?? parameters.maxEnergy;
                _nowEnergy = result;
                return result;
            }
            set {
                _nowEnergy = Mathf.Min(value, parameters.maxEnergy);
            }
        }

        /// <summary>
        /// 現在精神力
        /// </summary>
        int? _nowMental = null;
        /// <summary>
        /// 現在精神力
        /// </summary>
        public int nowMental
        {
            get {
                int result = _nowMental ?? parameters.maxMental;
                _nowMental = result;
                return result;
            }
            set {
                _nowMental = Mathf.Min(value, parameters.maxMental);
            }
        }

        /// <summary>
        /// 現在の行動優先度
        /// </summary>
        public int nowInitiative { get; set; } = 0;
    }
}
