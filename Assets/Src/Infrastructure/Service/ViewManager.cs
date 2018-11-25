using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using System;

namespace Assets.Src.Infrastructure.Service
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
            //TODO 実装する
            throw new NotImplementedException();
        }

        /// <summary>
        /// キャラクターのアクションを画面に反映する
        /// </summary>
        /// <param name="happened">アクション内容</param>
        /// <returns>描画処理成否</returns>
        public bool ReflectAction(Happened happened)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }

        /// <summary>
        /// エフェクトアクション描画関数
        /// </summary>
        /// <param name="effect">動作対象エフェクト</param>
        /// <returns>描画処理成否</returns>
        public bool OperateEffect(EffectAnimation effect)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
    }
}
