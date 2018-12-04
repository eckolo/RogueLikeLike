using Assets.Src.Domain.Model.Entity;
using Assets.Src.Domain.Model.Value;
using System;
using UnityEngine;

namespace Assets.Src.Domain.Factory
{
    /// <summary>
    /// <see cref="Map"/>の生成処理
    /// </summary>
    public static class MapFactory
    {
        /// <summary>
        /// 地域データと地域内座標をもとにマップを生成する
        /// </summary>
        /// <param name="originArea">地域データ</param>
        /// <param name="coordinate">地域内座標</param>
        /// <returns>生成されたマップ</returns>
        public static Map GenerateMap(this Area originArea, Vector2 coordinate)
        {
            //TODO 実装する
            throw new NotImplementedException();
        }
    }
}
