using Assets.Src.Models;
using Assets.Src.Models.Area;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Parameters parameters = new Parameters();

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
        /// マップデータ操作インターフェース
        /// </summary>
        public Map map
        {
            get {
                return parameters.map.Duplicate();
            }
            set {
                parameters.map = value.Duplicate();
            }
        }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public GameStates DuplicateMyself() => (GameStates)MemberwiseClone();
    }
}
