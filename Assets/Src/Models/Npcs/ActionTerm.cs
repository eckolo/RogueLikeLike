using Assets.Src.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Npcs
{
    /// <summary>
    /// 行動条件クラス
    /// </summary>
    [Serializable]
    public partial class ActionTerm
    {
        /// <summary>
        /// 該当行動パターン
        /// </summary>
        [SerializeField]
        ActionPattern _actionPattern = default(ActionPattern);
        /// <summary>
        /// 該当行動パターン
        /// </summary>
        public ActionPattern actionPattern => _actionPattern;

        /// <summary>
        /// 条件値オブジェクト
        /// 全ての条件を満たした場合該当する
        /// （つまりAND条件）
        /// </summary>
        [SerializeField]
        List<TermValue> _termList = new List<TermValue>();

        /// <summary>
        /// 指定されたゲーム状態下でこの条件が真か否か判定する
        /// </summary>
        /// <param name="myself">判定者</param>
        /// <param name="states">ゲーム状態</param>
        /// <returns>条件判定結果</returns>
        public bool Judge(Npc myself, GameStates states)
        {
            foreach(var term in _termList) if(!term.Judge(myself, states)) return false;
            return true;
        }
    }
}
