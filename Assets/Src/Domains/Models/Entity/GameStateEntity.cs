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
    public partial class GameStateEntity : IDuplicatable<GameStateEntity>
    {
        public GameStateEntity(int seedInt)
        {
            UnityEngine.Random.InitState(seedInt);
            _seed = UnityEngine.Random.state;
        }

        /// <summary>
        /// 所在地情報
        /// </summary>
        [SerializeField]
        Location _location = new Location();

        /// <summary>
        /// 上方向の方角
        /// </summary>
        public Direction upwardDirection
        {
            get { return _location.upwardDirection; }
            set { _location.upwardDirection = value; }
        }
        /// <summary>
        /// 全エリアデータ
        /// </summary>
        public List<Area> areaList { get { return _location.areaList; } set { _location.areaList = value; } }
        /// <summary>
        /// 現在のエリア情報
        /// </summary>
        public Area nowArea { get { return _location.nowArea; } set { _location.nowArea = value; } }
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
        /// 乱数の種
        /// </summary>
        [SerializeField]
        readonly UnityEngine.Random.State _seed = default(UnityEngine.Random.State);
        /// <summary>
        /// 乱数の種
        /// </summary>
        public UnityEngine.Random.State seed => _seed;

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public GameStateEntity MemberwiseClonePublic() => (GameStateEntity)MemberwiseClone();
    }
}
