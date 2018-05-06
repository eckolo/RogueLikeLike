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

        /// <summary>
        /// その場1マスのみの範囲
        /// </summary>
        public static Coverage one
            => new Coverage(new Dictionary<Vector2, int> { { Vector2.zero, 0 } });
        /// <summary>
        /// 該当箇所の無い範囲
        /// </summary>
        public static Coverage zero => new Coverage(new Dictionary<Vector2, int>());

        Coverage(Dictionary<Vector2, int> target, Dictionary<Vector2, int> exclude = null)
        {
            _targetRanges = target;
            _excludeRanges = exclude ?? new Dictionary<Vector2, int>();
        }

        /// <summary>
        /// 含む範囲
        /// </summary>
        [SerializeField]
        List<TargetPointRadius> _targetPoints = new List<TargetPointRadius>();

        /// <summary>
        /// (0,0)を起点とした対象座標と各地点の半径リスト
        /// </summary>
        protected Dictionary<Vector2, int> GetTargetRanges(Direction direction)
        {
            if(_targetRanges == null) _targetRanges = _targetPoints
                    .Where(point => !point.exclusion)
                    .ToDictionary();

            return _targetRanges
                .ToDictionary(range => range.Key.Rotate(direction), range => range.Value);
        }
        /// <summary>
        /// (0,0)を起点とした上向きの場合の対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, int> _targetRanges = null;

        /// <summary>
        /// (0,0)を起点とした除外対象座標と各地点の半径リスト
        /// </summary>
        protected Dictionary<Vector2, int> GetExcludeRanges(Direction direction)
        {
            if(_excludeRanges == null) _excludeRanges = _targetPoints
                    .Where(point => point.exclusion)
                    .ToDictionary();

            return _excludeRanges
                .ToDictionary(range => range.Key.Rotate(direction), range => range.Value);
        }
        /// <summary>
        /// (0,0)を起点とした上向きの場合の除外対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, int> _excludeRanges = null;

        /// <summary>
        /// 対象マスの列挙
        /// </summary>
        /// <param name="center">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <param name="direction">範囲の回転方向</param>
        /// <returns>対象マス一覧</returns>
        public IEnumerable<Vector2> EnumerateTargetPoints(Vector2? center = null, Direction direction = Direction.NORTH)
            => GetTargetRanges(direction)
            .SelectMany(range => GetRoundRange(range.Key, range.Value))
            .Where(vector => !IsInclude(GetExcludeRanges(direction), vector))
            .Select(vector => (center ?? Vector2.zero) + vector);

        IEnumerable<Vector2> GetRoundRange(Vector2 center, int radius)
            => GetDiameterLine(radius)
            .SelectMany(_ => GetDiameterLine(radius), (x, y) => new Vector2(x, y))
            .Where(vector => vector.magnitude <= radius + HALF_MAS)
            .Select(vector => center + vector);
        IEnumerable<int> GetDiameterLine(int radius) => Enumerable.Range(-radius, radius * 2 + 1);

        /// <summary>
        /// 指定された座標が範囲に含まれるか否か判定する
        /// </summary>
        /// <param name="_target">指定座標</param>
        /// <param name="center">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <param name="direction">範囲の回転方向</param>
        /// <returns>指定された座標が範囲に含まれていればTrue</returns>
        public bool OnTarget(Vector2 _target, Vector2? center = null, Direction direction = Direction.NORTH)
        {
            var basePoint = center ?? Vector2.zero;
            var target = _target - basePoint;

            return IsInclude(GetTargetRanges(direction), target)
                && !IsInclude(GetExcludeRanges(direction), target);
        }

        bool IsInclude(Dictionary<Vector2, int> Ranges, Vector2 target)
            => Ranges.Any(range => (target - range.Key).magnitude <= range.Value + HALF_MAS);
    }
}
