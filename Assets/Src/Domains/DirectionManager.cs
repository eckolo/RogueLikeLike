using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 方角関係のユーティリティクラス
    /// </summary>
    public static class DirectionManager
    {
        /// <summary>
        /// 方角を単位ベクトルに変換する関数
        /// </summary>
        /// <param name="origin">元の方角</param>
        /// <returns>単位ベクトル</returns>
        public static Vector2 ToVector(this Direction origin)
        {
            switch(origin)
            {
                case Direction.NORTH: return Vector2.up;
                case Direction.SOUTH: return Vector2.down;
                case Direction.EAST: return Vector2.right;
                case Direction.WEST: return Vector2.left;
                default: throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// 単位ベクトルを方角に変換する関数
        /// </summary>
        /// <param name="vector">単位ベクトル</param>
        /// <returns>方角</returns>
        public static Direction ToDirection(this Vector2 vector)
        {
            var normalized = vector.normalized;
            if(normalized == Vector2.up) return Direction.NORTH;
            if(normalized == Vector2.down) return Direction.SOUTH;
            if(normalized == Vector2.right) return Direction.EAST;
            if(normalized == Vector2.left) return Direction.WEST;
            throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// 方向を回転させた方角を取得する
        /// </summary>
        /// <param name="origin">元の方向</param>
        /// <param name="top">
        /// 回転量を示す方角
        /// この方角が上を向いている時に、北が上を向くよう回転させる
        /// </param>
        /// <returns></returns>
        public static Direction Rotation(this Direction origin, Direction top)
        {
            return origin;
        }
    }
}
