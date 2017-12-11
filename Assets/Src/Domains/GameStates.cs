using Assets.Src.Models;
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
        /// インスタンス生成用のプライベートなコンストラクタ
        /// </summary>
        GameStates() { }

        /// <summary>
        /// 状態（つまりStateHolder自身）を取得する関数
        /// </summary>
        /// <returns>既にインスタンス生成されていればそれを、無ければ新規生成して返す</returns>
        public static GameStates nowState => myself ?? new GameStates();

        /// <summary>
        /// ビューデータ操作インターフェース
        /// </summary>
        public View view
        {
            get {
                return default(View);
            }
            set {

            }
        }

        /// <summary>
        /// シャローコピーメソッド
        /// </summary>
        /// <returns>コピーされたオブジェクト</returns>
        public GameStates DuplicateMyself() => (GameStates)MemberwiseClone();
    }
}
