using Assets.Src.Domains.Service;
using Assets.Src.Domains.Models;
using Assets.Src.Domains.Models.Areas;
using Assets.Src.Domains.Models.Npcs;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
        IStateEntity _stateEntity = new StateEntity();

        /// <summary>
        /// インフラアクセスメソッド群
        /// </summary>
        static InjectedMethods _methods = null;

        /// <summary>
        /// インスタンス生成用のプライベートなコンストラクタ
        /// </summary>
        /// <param name="stateEntity">初期状態</param>
        GameStates(IStateEntity stateEntity)
        {
            _methods = methods ?? new InjectedMethods(
                viewer: new ViewManager(),
                fileManager: new FileManager(),
                skillRepository: new SkillRepository()
                );
            _stateEntity = stateEntity ?? _stateEntity.Duplicate();
        }

        /// <summary>
        /// 新規ゲーム状態生成メソッド
        /// </summary>
        /// <param name="stateEntity">初期状態</param>
        /// <returns>生成されたゲーム状態</returns>
        public static GameStates CreateNewState(IStateEntity stateEntity = null)
        {
            if(myself == null) return myself = new GameStates(stateEntity);
            myself.stateEntity = stateEntity;
            return myself;
        }

        /// <summary>
        /// インフラアクセスメソッド群アクセス用インターフェース
        /// </summary>
        public InjectedMethods methods => _methods;

        /// <summary>
        /// パラメータ一括アクセス用プロパティ
        /// </summary>
        public IStateEntity stateEntity
        {
            get {
                return _stateEntity.Duplicate();
            }
            set {
                _stateEntity = value.Duplicate();
            }
        }

        /// <summary>
        /// 現在地情報
        /// </summary>
        public Location location
        {
            get {
                return _stateEntity.location.Duplicate();
            }
            set {
                _stateEntity.location = value.Duplicate();
            }
        }
        /// <summary>
        /// 現在の地域データ
        /// </summary>
        public Area area
        {
            get {
                return _stateEntity.location.area.Duplicate();
            }
            set {
                _stateEntity.location.area = value.Duplicate();
            }
        }
        /// <summary>
        /// 現在のマップデータ
        /// </summary>
        public Map map
        {
            get {
                return _stateEntity.location.map.Duplicate();
            }
            set {
                _stateEntity.location.map = value.Duplicate();
            }
        }

        /// <summary>
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        public IEnumerable<Npc> npcList => _stateEntity.npcList.Select(npcData => npcData.Value);
        /// <summary>
        /// 現在の行動者
        /// </summary>
        public Npc actor
        {
            get {
                return _stateEntity.actor;
            }
            set {
                _stateEntity.actor = value ?? _stateEntity.actor;
            }
        }
        /// <summary>
        /// 座標から座標上に存在するNPCを返す
        /// 座標上に誰もいなければNullが返る
        /// </summary>
        /// <param name="key">NPCの存在座標</param>
        /// <returns>NPC</returns>
        public Npc GetNpc(Vector2 key) => _stateEntity.npcList.ContainsKey(key) ? _stateEntity.npcList[key] : null;
        /// <summary>
        /// NPCからその存在座標を返す
        /// NPCがマップ上に存在していなければNullを返す
        /// </summary>
        /// <param name="npc"></param>
        /// <returns></returns>
        public Vector2? GetCoordinate(Npc npc)
            => npc != null && npcList.Contains(npc) ?
            _stateEntity.npcList.FirstOrDefault(npcData => npcData.Value == npc).Key :
            (Vector2?)null;

        /// <summary>
        /// 行動履歴に追加
        /// </summary>
        /// <param name="happened">履歴に追加される行動内容</param>
        public void AddHappenedLog(Happened happened)
        {
            _stateEntity.happenedLog.Add(happened);
        }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public IGameStates MemberwiseClonePublic() => (GameStates)MemberwiseClone();
    }
}
