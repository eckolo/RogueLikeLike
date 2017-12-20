using Assets.Src.Models;
using Assets.Src.Models.Area;
using Assets.Src.Models.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 状態保持クラス
    /// シングルトンとして中身を保持する
    /// </summary>
    public partial class GameStates : IDuplicatable<GameStates>
    {
        /// <summary>
        /// 実際のインスタンス
        /// </summary>
        static GameStates myself = null;

        /// <summary>
        /// パラメータ実体
        /// </summary>
        Parameters _parameters = new Parameters();

        /// <summary>
        /// インフラアクセスメソッド群
        /// </summary>
        InjectedMethods _methods = new InjectedMethods();

        /// <summary>
        /// インスタンス生成用のプライベートなコンストラクタ
        /// </summary>
        /// <param name="methods">インフラアクセスメソッド群の実体</param>
        GameStates(InjectedMethods methods)
        {
            _methods = methods;
        }

        /// <summary>
        /// 状態（つまりStateHolder自身）を取得する関数
        /// </summary>
        /// <param name="methods">インフラアクセスメソッド群の実体</param>
        /// <returns>既にインスタンス生成されていればそれを、無ければ新規生成して返す</returns>
        public static GameStates GetNowState(InjectedMethods methods = null)
            => (myself ?? (myself = new GameStates(methods))).Duplicate();

        /// <summary>
        /// インフラアクセスメソッド群アクセス用インターフェース
        /// </summary>
        public InjectedMethods methods => _methods;

        /// <summary>
        /// 現在地情報
        /// </summary>
        public Location location
        {
            get {
                return _parameters.location.Duplicate();
            }
            set {
                _parameters.location = value.Duplicate();
            }
        }
        /// <summary>
        /// 現在のマップデータ
        /// </summary>
        public Map map
        {
            get {
                return _parameters.location.map.Duplicate();
            }
            set {
                _parameters.location.map = value.Duplicate();
            }
        }

        /// <summary>
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        public List<Npc> npcList => _parameters.npcList.Select(npcData => npcData.Value).ToList();
        /// <summary>
        /// 座標から座標上に存在するNPCを返す
        /// 座標上に誰もいなければNullが返る
        /// </summary>
        /// <param name="key">NPCの存在座標</param>
        /// <returns>NPC</returns>
        public Npc GetNpc(Vector2 key) => _parameters.npcList.ContainsKey(key) ? _parameters.npcList[key] : null;
        /// <summary>
        /// NPCからその存在座標を返す
        /// NPCがマップ上に存在していなければNullを返す
        /// </summary>
        /// <param name="npc"></param>
        /// <returns></returns>
        public Vector2? GetCoordinate(Npc npc)
            => npcList.Contains(npc) ?
            _parameters.npcList.FirstOrDefault(npcData => npcData.Value == npc).Key :
            (Vector2?)null;

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public GameStates MemberwiseClonePublic() => (GameStates)MemberwiseClone();
    }
}
