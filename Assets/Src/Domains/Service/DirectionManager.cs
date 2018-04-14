using Assets.Src.Domains.Models.Value;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Service
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
        /// 方角を単位ベクトルに変換する関数
        /// </summary>
        /// <param name="origin">元の方角</param>
        /// <returns>単位ベクトル</returns>
        public static Vector2 ToVector(this Direction? origin) => origin?.ToVector() ?? Vector2.zero;

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
        /// 元の北方向をこの方角へ回転させる
        /// </param>
        /// <returns>回転された方角</returns>
        public static Direction Rotation(this Direction origin, Direction top)
        {
            switch(origin)
            {
                case Direction.NORTH:
                    switch(top)
                    {
                        case Direction.NORTH: return Direction.NORTH;
                        case Direction.SOUTH: return Direction.SOUTH;
                        case Direction.EAST: return Direction.EAST;
                        case Direction.WEST: return Direction.WEST;
                        default: throw new IndexOutOfRangeException();
                    }
                case Direction.SOUTH:
                    switch(top)
                    {
                        case Direction.NORTH: return Direction.SOUTH;
                        case Direction.SOUTH: return Direction.NORTH;
                        case Direction.EAST: return Direction.WEST;
                        case Direction.WEST: return Direction.EAST;
                        default: throw new IndexOutOfRangeException();
                    }
                case Direction.EAST:
                    switch(top)
                    {
                        case Direction.NORTH: return Direction.EAST;
                        case Direction.SOUTH: return Direction.WEST;
                        case Direction.EAST: return Direction.SOUTH;
                        case Direction.WEST: return Direction.NORTH;
                        default: throw new IndexOutOfRangeException();
                    }
                case Direction.WEST:
                    switch(top)
                    {
                        case Direction.NORTH: return Direction.WEST;
                        case Direction.SOUTH: return Direction.EAST;
                        case Direction.EAST: return Direction.NORTH;
                        case Direction.WEST: return Direction.SOUTH;
                        default: throw new IndexOutOfRangeException();
                    }
                default: throw new IndexOutOfRangeException();
            }
        }
    }
}
