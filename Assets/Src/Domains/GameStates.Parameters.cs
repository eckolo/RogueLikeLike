using Assets.Src.Models;
using Assets.Src.Models.Area;
using Assets.Src.Models.Person;
using System.Collections.Generic;

namespace Assets.Src.Domains
{
    public partial class GameStates
    {
        /// <summary>
        /// メインパラメータ
        /// </summary>
        class Parameters
        {
            /// <summary>
            /// ターン毎のマップ状態
            /// </summary>
            public Map map { get; set; }
            /// <summary>
            /// このターンの行動履歴
            /// </summary>
            public List<KeyValuePair<Npc, PersonBehavior>> updateList { get; set; }
        }
    }
}
