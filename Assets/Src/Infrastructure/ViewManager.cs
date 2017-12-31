using Assets.Src.Domains;
using Assets.Src.Models;
using Assets.Src.Models.Areas;
using System;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// 画面表示とか周りの処理クラス
    /// </summary>
    public class ViewManager : IViewManager
    {
        /// <summary>
        /// 現在のマップ状況を画面に反映する
        /// </summary>
        /// <param name="map">反映元マップデータ</param>
        /// <param name="topDirection">画面上方向の方角</param>
        /// <returns>更新処理成否</returns>
        public bool ReflectMap(Map map, Direction topDirection = Direction.NORTH)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// キャラクターのアクションを画面に反映する
        /// </summary>
        /// <param name="behavior">アクション内容</param>
        /// <returns>描画処理成否</returns>
        public bool ReflectAction(Happened behavior)
        {
            throw new NotImplementedException();
        }
    }
}
