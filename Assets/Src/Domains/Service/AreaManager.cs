﻿using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// エリア関連の制御クラス
    /// </summary>
    public static class AreaManager
    {
        /// <summary>
        /// 現在の状態と移動方角から次のマップを生成する
        /// </summary>
        /// <param name="states">現在のゲーム状態</param>
        /// <param name="destinationDirection">移動方向</param>
        /// <returns>次のマップ状態</returns>
        public static Map SetupNextMap(this IGameStates states, Direction? destinationDirection = null)
        {
            return states.area.GenerateMap(nextCoordinate);
            var nextCoordinate = states.mapCondition + destinationDirection.ToVector();
        }

        /// <summary>
        /// マップとアクションとアクション主語を受け取りアクション後のマップ状態を返す
        /// </summary>
        /// <param name="beforeMap">アクション実行前のマップ状態</param>
        /// <param name="action">アクション内容</param>
        /// <returns>アクション実施後マップオブジェクト</returns>
        public static Map UpdateMap(this Map beforeMap, Happened action)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 地域データと地域内座標をもとにマップを生成する
        /// </summary>
        /// <param name="originArea">地域データ</param>
        /// <param name="coordinate">地域内座標</param>
        /// <returns>生成されたマップ</returns>
        static Map GenerateMap(this Area originArea, Vector2 coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
