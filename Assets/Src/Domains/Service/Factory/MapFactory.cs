using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Service.Factory
{
    /// <summary>
    /// Mapの生成処理
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
            throw new NotImplementedException();
        }
    }
}
