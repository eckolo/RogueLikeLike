using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Assets.Src.Domains.Models.Entity;
using Assets.Src.Infrastructure.Repository;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// 状態保持クラス
    /// シングルトンとして中身を保持する
    /// </summary>
    public partial class GameStates : IGameStates
    {
        /// <summary>
        /// 現在有効なゲーム状態の実体
        /// </summary>
        static GameStates myself = null;

        /// <summary>
        /// パラメータ実体
        /// </summary>
        GameStateEntity _stateEntity = null;

        /// <summary>
        /// インフラアクセスメソッド群
        /// </summary>
        static InjectedMethods _methods = null;

        /// <summary>
        /// インジェクション用メソッド定義のために初回生成時のみ起動
        /// </summary>
        static GameStates()
        {
            _methods = new InjectedMethods(
                viewer: new ViewManager(),
                fileManager: new FileManager(),
                skillRepository: new SkillRepository());
        }

        /// <summary>
        /// インスタンス生成用のプライベートなコンストラクタ
        /// </summary>
        /// <param name="_stateEntity">初期状態</param>
        GameStates(GameStateEntity _stateEntity)
        {
            this._stateEntity = _stateEntity ?? this._stateEntity.Duplicate();
        }

        /// <summary>
        /// 新規ゲーム状態生成メソッド
        /// </summary>
        /// <param name="_stateEntity">初期状態</param>
        /// <returns>生成されたゲーム状態</returns>
        public static GameStates CreateNewState(GameStateEntity _stateEntity)
        {
            if(myself == null) return myself = myself ?? new GameStates(_stateEntity);
            myself._stateEntity = _stateEntity.Duplicate();
            return myself;
        }
        /// <summary>
        /// 新規ゲーム状態生成メソッド
        /// </summary>
        /// <param name="randamSeed">乱数の種</param>
        /// <returns>生成されたゲーム状態</returns>
        public static GameStates CreateNewState(int randamSeed) => CreateNewState(new GameStateEntity(randamSeed));

        /// <summary>
        /// インフラアクセスメソッド群アクセス用インターフェース
        /// </summary>
        public InjectedMethods methods => _methods;

        /// <summary>
        /// パラメータ一括アクセス用プロパティ
        /// </summary>
        public GameStateEntity stateEntity
        {
            get { return _stateEntity.Duplicate(); }
            set { _stateEntity = value.Duplicate(); }
        }

        /// <summary>
        /// 画面反映待ちキュー
        /// </summary>
        public Queue<Happened> viewQueue => _stateEntity.viewQueue;

        /// <summary>
        /// 全エリアデータ
        /// </summary>
        public List<Area> areaList => _stateEntity.areaList;
        /// <summary>
        /// 現在の地域データ
        /// </summary>
        public Area area
        {
            get { return _stateEntity.nowArea.Duplicate(); }
            set { _stateEntity.nowArea = value.Duplicate(); }
        }
        /// <summary>
        /// 現在のマップデータ
        /// </summary>
        public Map map
        {
            get { return _stateEntity.nowMap.Duplicate(); }
            set { _stateEntity.nowMap = value.Duplicate(); }
        }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        public Vector2 mapCondition
        {
            get { return _stateEntity.nowMapCondition; }
            set { _stateEntity.nowMapCondition = value; }
        }

        /// <summary>
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        public IEnumerable<Npc> npcList => _stateEntity.nowNpcList.Select(npcData => npcData.Value);

        /// <summary>
        /// 乱数の種
        /// </summary>
        public Random.State seed => stateEntity.seed;

        /// <summary>
        /// 座標から座標上に存在するNPCを返す
        /// 座標上に誰もいなければNullが返る
        /// </summary>
        /// <param name="key">NPCの存在座標</param>
        /// <returns>NPC</returns>
        public Npc GetNpc(Vector2 key) => _stateEntity.nowNpcList.ContainsKey(key) ? _stateEntity.nowNpcList[key] : null;
        /// <summary>
        /// NPCからその存在座標を返す
        /// NPCがマップ上に存在していなければNullを返す
        /// </summary>
        /// <param name="npc"></param>
        /// <returns></returns>
        public Vector2? GetCoordinate(Npc npc)
            => npc != null && npcList.Contains(npc) ?
            _stateEntity.nowNpcList.FirstOrDefault(npcData => npcData.Value == npc).Key :
            (Vector2?)null;

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public IGameStates MemberwiseClonePublic() => (GameStates)MemberwiseClone();
    }
}
