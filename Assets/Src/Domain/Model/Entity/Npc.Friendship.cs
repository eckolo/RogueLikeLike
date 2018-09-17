using System.Collections.Generic;
using Assets.Src.Domain.Model.Value;
using UnityEngine;

namespace Assets.Src.Domain.Model.Entity
{
    public partial class Npc
    {
        /// <summary>
        /// NPC毎に対する友好度合いクラス
        /// 辞書型の初期化処理を隠蔽するためインデクサで定義
        /// </summary>
        public class Friendship
        {
            /// <summary>
            /// 各NPCへの友好度
            /// 0より大きければ友好、0未満なら敵対、0丁度なら無関心
            /// 値が無い場合は0扱い
            /// </summary>
            Dictionary<Npc, int> _friendship = new Dictionary<Npc, int>();

            public int this[Npc npcKey]
            {
                get {
                    if(!_friendship.ContainsKey(npcKey)) _friendship.Add(npcKey, 0);
                    return _friendship[npcKey];
                }
                set {
                    value = Mathf.Clamp(value, -100, 100);
                    if(!_friendship.ContainsKey(npcKey)) _friendship.Add(npcKey, value);
                    else _friendship[npcKey] = value;
                }
            }
        }
    }
}
