using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 画面表示とか周りの処理クラス
    /// </summary>
    public static class ViewManager
    {
        /// <summary>
        /// 画面内のマップ上の状況を更新する
        /// </summary>
        /// <param name="viewState">描画に関わる状態の情報</param>
        /// <returns>更新処理成否</returns>
        public static bool Update(this GameStates.View viewState)
        {
            return true;
        }
    }
}
