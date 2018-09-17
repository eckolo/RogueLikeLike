using System.Collections.Generic;
using UnityEngine;
using System;
using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Model.Abstract;
using System.Linq;

namespace Assets.Src.Domain.Model.Entity
{
    /// <summary>
    /// ゲーム状態クラス
    /// </summary>
    [Serializable]
    public partial class GameState : IDuplicatable<GameState>
    {
        public GameState(int seedInt)
        {
            UnityEngine.Random.InitState(seedInt);
            _seed = UnityEngine.Random.state;
        }

        /// <summary>
        /// ゲーム設定
        /// </summary>
        [SerializeField]
        Configs _configs = new Configs();
        /// <summary>
        /// ゲーム設定
        /// </summary>
        public Configs configs { get { return _configs; } set { _configs = value; } }

        /// <summary>
        /// 現在の外部入力可否
        /// </summary>
        [SerializeField]
        bool _recievable = true;
        /// <summary>
        /// 現在の外部入力可否
        /// </summary>
        public bool recievable { get { return _recievable; } set { _recievable = value; } }

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
        public Area area { get { return _location.nowArea; } set { _location.nowArea = value; } }
        /// <summary>
        /// 現在のマップ状態
        /// </summary>
        public Map map { get { return area.nowMap; } set { area.nowMap = value; } }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        public Vector2 nowMapCondition
        {
            get { return area.nowMapCondition; }
            set { area.nowMapCondition = value; }
        }

        /// <summary>
        /// 現在のマップのNPC配置情報
        /// </summary>
        public Dictionary<Vector2, Npc> npcLayout
        {
            get { return map.npcLayout; }
            set { map.npcLayout = value; }
        }

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
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        public virtual IEnumerable<Npc> npcList => npcLayout.Select(npcData => npcData.Value);

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
        public GameState MemberwiseClonePublic() => (GameState)MemberwiseClone();
    }
}
