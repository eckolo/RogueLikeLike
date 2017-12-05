using Assets.Src.Models;
using Assets.Src.Models.Area;
using Assets.Src.Models.Person;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains
{
    public partial class GameStates
    {
        /// <summary>
        /// 画面表示状態の保持
        /// </summary>
        public class View
        {
            /// <summary>
            /// 1ターン前のマップ状態
            /// </summary>
            public Map beforeMap { get; set; }

            /// <summary>
            /// 描画の更新用全オブジェクトの今回の行動リスト
            /// </summary>
            public List<KeyValuePair<Npc, PersonBehavior>> updateList { get; set; }
        }
    }
}
