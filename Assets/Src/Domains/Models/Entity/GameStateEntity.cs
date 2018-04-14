using System.Collections.Generic;
using UnityEngine;
using System;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Models.Interface;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// ゲーム状態のメインパラメータ
    /// </summary>
    [Serializable]
    public class GameStateEntity : IDuplicatable<GameStateEntity>
    {
        /// <summary>
        /// 現在の所在地情報
        /// </summary>
        [SerializeField]
        Location _location = new Location();
        /// <summary>
        /// 現在の所在地情報
        /// </summary>
        public Location location { get { return _location; } set { _location = value; } }

        /// <summary>
        /// 各マスのNPCリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// </summary>
        [SerializeField]
        Dictionary<Vector2, Npc> _npcList = new Dictionary<Vector2, Npc>();
        /// <summary>
        /// 各マスのNPCリスト
        /// 座標は中央が(0,0)、東がx+1、北がY+1
        /// </summary>
        public Dictionary<Vector2, Npc> npcList { get { return _npcList; } set { _npcList = value; } }

        /// <summary>
        /// 画面未反映の行動履歴
        /// </summary>
        [SerializeField]
        Queue<Happened> _viewQueue = new Queue<Happened>();
        /// <summary>
        /// 画面未反映の行動履歴
        /// </summary>
        public Queue<Happened> viewQueue { get { return _viewQueue; } set { _viewQueue = value; } }

        /// <summary>
        /// 現在の行動者
        /// </summary>
        [SerializeField]
        Npc _actor = null;
        /// <summary>
        /// 現在の行動者
        /// </summary>
        public Npc actor { get { return _actor; } set { _actor = value; } }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public GameStateEntity MemberwiseClonePublic() => (GameStateEntity)MemberwiseClone();
    }
}
