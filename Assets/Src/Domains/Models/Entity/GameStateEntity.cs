using System.Collections.Generic;
using UnityEngine;
using System;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Service;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// ゲーム状態のメインパラメータ
    /// </summary>
    [Serializable]
    public class GameStateEntity : IDuplicatable<GameStateEntity>
    {
        /// <summary>
        /// 上方向の方角
        /// </summary>
        [SerializeField]
        Direction _upwardDirection = Direction.NORTH;
        /// <summary>
        /// 上方向の方角
        /// </summary>
        public Direction upwardDirection { get { return _upwardDirection; } set { _upwardDirection = value; } }

        /// <summary>
        /// 全エリアデータ
        /// </summary>
        [SerializeField]
        List<Area> _areaList = new List<Area>();
        /// <summary>
        /// 全エリアデータ
        /// </summary>
        public List<Area> areaList { get { return _areaList; } set { _areaList = value; } }

        /// <summary>
        /// 現在のエリア情報
        /// </summary>
        public Area nowArea
        {
            get {
                if(!areaList.ContainsIndex(_nowAreaNum)) return null;
                return areaList[_nowAreaNum];
            }
            set {
                if(!areaList.Contains(value)) areaList.Add(value);
                _nowAreaNum = areaList.IndexOf(value);
            }
        }
        /// <summary>
        /// 所在エリア番号
        /// </summary>
        int _nowAreaNum = 0;
        /// <summary>
        /// 現在のマップ状態
        /// </summary>
        public Map nowMap { get { return nowArea.nowMap; } set { nowArea.nowMap = value; } }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        public Vector2 nowMapCondition
        {
            get { return nowArea.nowMapCondition; }
            set { nowArea.nowMapCondition = value; }
        }

        /// <summary>
        /// 現在のマップのNPC配置情報
        /// </summary>
        public Dictionary<Vector2, Npc> nowNpcList { get { return nowMap.npcList; } set { nowMap.npcList = value; } }

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
