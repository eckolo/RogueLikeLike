using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 詳細なマス目指定の範囲指定
    /// </summary>
    [Serializable]
    public partial class Coverage
    {
        const float HALF_MAS = 0.5f;

        public Coverage(IEnumerable<PointRadius> ranges)
        {
            _targetRanges = ranges.Where(point => !point.exclusion).ToDictionary();
            _excludeRanges = ranges.Where(point => point.exclusion).ToDictionary();
        }

        /// <summary>
        /// 範囲の移動
        /// </summary>
        /// <param name="center">中心座標</param>
        /// <param name="direction">上を向く方角</param>
        /// <returns>移動操作後の範囲オブジェクト</returns>
        public Coverage Move(Vector2? center = null, Direction? direction = null)
            => new Coverage(_targetRanges, _excludeRanges, center ?? _center, direction ?? _direction);
        /// <summary>
        /// 範囲の移動
        /// </summary>
        /// <param name="direction">上を向く方角</param>
        /// <returns>移動操作後の範囲オブジェクト</returns>
        public Coverage Move(Direction direction) => Move(_center, direction);

        /// <summary>
        /// その場1マスのみの範囲
        /// </summary>
        public static Coverage one => new Coverage(new Dictionary<Vector2, int> { { Vector2.zero, 0 } });
        /// <summary>
        /// 該当箇所の無い範囲
        /// </summary>
        public static Coverage zero => new Coverage(new Dictionary<Vector2, int>());

        Coverage(Dictionary<Vector2, int> target, Dictionary<Vector2, int> exclude = null, Vector2? center = null, Direction direction = Direction.NORTH)
        {
            _targetRanges = target;
            _excludeRanges = exclude ?? new Dictionary<Vector2, int>();
            _center = center ?? Vector2.zero;
            _direction = direction;
        }

        /// <summary>
        /// (0,0)を起点、北を上とした場合の対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, int> _targetRanges = null;
        /// <summary>
        /// (0,0)を起点、北を上とした場合の除外対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, int> _excludeRanges = null;
        /// <summary>
        /// 範囲の起点座標
        /// </summary>
        Vector2 _center = Vector2.zero;
        /// <summary>
        /// どの方角を上とするか
        /// </summary>
        Direction _direction = Direction.NORTH;

        /// <summary>
        /// (0,0)を起点とした対象座標と各地点の半径リスト
        /// </summary>
        protected Dictionary<Vector2, int> targetRanges => _targetRanges
                .ToDictionary(range => range.Key.Rotate(_direction), range => range.Value);

        /// <summary>
        /// (0,0)を起点とした除外対象座標と各地点の半径リスト
        /// </summary>
        protected Dictionary<Vector2, int> excludeRanges => _excludeRanges
                .ToDictionary(range => range.Key.Rotate(_direction), range => range.Value);

        /// <summary>
        /// 対象マスの列挙
        /// </summary>
        /// <param name="center">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <param name="direction">範囲の回転方向</param>
        /// <returns>対象マス一覧</returns>
        public IEnumerable<Vector2> EnumerateTargetPoints()
            => targetRanges
            .SelectMany(range => GetRoundRange(range.Key, range.Value))
            .Where(vector => !IsInclude(excludeRanges, vector))
            .Select(vector => _center + vector);

        IEnumerable<Vector2> GetRoundRange(Vector2 localCenter, int radius)
            => GetDiameterLine(radius)
            .SelectMany(_ => GetDiameterLine(radius), (x, y) => new Vector2(x, y))
            .Where(vector => vector.magnitude <= radius + HALF_MAS)
            .Select(vector => localCenter + vector);
        IEnumerable<int> GetDiameterLine(int radius) => Enumerable.Range(-radius, radius * 2 + 1);

        /// <summary>
        /// 指定された座標が範囲に含まれるか否か判定する
        /// </summary>
        /// <param name="target">指定座標</param>
        /// <param name="center">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <param name="direction">範囲の回転方向</param>
        /// <returns>指定された座標が範囲に含まれていればTrue</returns>
        public bool OnTarget(Vector2 target)
            => IsInclude(targetRanges, target - _center)
            && !IsInclude(excludeRanges, target - _center);

        bool IsInclude(Dictionary<Vector2, int> Ranges, Vector2 target)
            => Ranges.Any(range => (target - range.Key).magnitude <= range.Value + HALF_MAS);
    }
}
