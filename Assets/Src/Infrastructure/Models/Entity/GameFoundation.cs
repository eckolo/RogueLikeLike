using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using Assets.Src.Infrastructure.Repository;
using Assets.Src.Infrastructure.Service;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Infrastructure.Models.Entity
{
    /// <summary>
    /// ゲーム基盤クラス
    /// シングルトンとして中身を保持する
    /// </summary>
    public partial class GameFoundation : IGameFoundation
    {
        /// <summary>
        /// 現在有効なゲーム基盤の実体
        /// </summary>
        static GameFoundation myself = null;

        /// <summary>
        /// ゲーム状態
        /// </summary>
        GameState _state = null;

        /// <summary>
        /// インフラアクセスメソッド群
        /// </summary>
        static InjectedMethods _methods = null;

        /// <summary>
        /// インジェクション用メソッド定義のために初回生成時のみ起動
        /// </summary>
        static GameFoundation()
        {
            _methods = new InjectedMethods(
                viewer: new ViewManager(),
                fileManager: new FileManager(),
                skillRepository: new SkillRepository(),
                areaRepository: new AreaRepository());
        }

        /// <summary>
        /// インスタンス生成用のプライベートなコンストラクタ
        /// </summary>
        /// <param name="_state">初期ゲーム基盤</param>
        GameFoundation(GameState _state)
        {
            this._state = _state ?? this._state.Duplicate();
        }

        /// <summary>
        /// 新規ゲーム基盤生成メソッド
        /// </summary>
        /// <param name="_state">初期状態</param>
        /// <returns>生成されたゲーム基盤</returns>
        public static GameFoundation CreateNewState(GameState _state)
        {
            if(myself == null) return myself = myself ?? new GameFoundation(_state);
            myself._state = _state.Duplicate();
            return myself;
        }
        /// <summary>
        /// 新規ゲーム基盤生成メソッド
        /// </summary>
        /// <param name="randamSeed">乱数の種</param>
        /// <returns>生成されたゲーム基盤</returns>
        public static GameFoundation CreateNewState(int randamSeed) => CreateNewState(new GameState(randamSeed));

        /// <summary>
        /// インフラアクセスメソッド群アクセス用インターフェース
        /// </summary>
        public InjectedMethods methods => _methods;

        /// <summary>
        /// パラメータ一括アクセス用プロパティ
        /// </summary>
        public GameState nowState
        {
            get { return _state.Duplicate(); }
            set { _state = value.Duplicate(); }
        }

        /// <summary>
        /// 画面反映待ちキュー
        /// </summary>
        public Queue<Happened> viewQueue => _state.viewQueue;

        /// <summary>
        /// 全エリアデータ
        /// </summary>
        public List<Area> areaList => _state.areaList;
        /// <summary>
        /// 現在の地域データ
        /// </summary>
        public Area nowArea
        {
            get { return _state.area.Duplicate(); }
            set { _state.area = value.Duplicate(); }
        }
        /// <summary>
        /// 現在のマップデータ
        /// </summary>
        public Map nowMap
        {
            get { return _state.map.Duplicate(); }
            set { _state.map = value.Duplicate(); }
        }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        public Vector2 nowMapCondition
        {
            get { return _state.nowMapCondition; }
            set { _state.nowMapCondition = value; }
        }

        /// <summary>
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        public IEnumerable<Npc> nowNpcList => _state.npcList;

        /// <summary>
        /// 乱数の種
        /// </summary>
        public Random.State nowSeed => nowState.seed;

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public IGameFoundation MemberwiseClonePublic() => (GameFoundation)MemberwiseClone();
    }
}
