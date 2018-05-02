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
    public partial class SpecifiedRange
    {
        /// <summary>
        /// その場1マスのみの範囲
        /// </summary>
        public static readonly SpecifiedRange one
            = new SpecifiedRange(new Dictionary<Vector2, int> { { Vector2.zero, 0 } });
        /// <summary>
        /// 該当箇所の無い範囲
        /// </summary>
        public static SpecifiedRange zero => new SpecifiedRange(new Dictionary<Vector2, int>());

        SpecifiedRange(Dictionary<Vector2, int> target, Dictionary<Vector2, int> exclude = null)
        {
            _targetPointRadiuses = target;
            _excludePointRadiuses = exclude ?? new Dictionary<Vector2, int>();
        }

        /// <summary>
        /// 含む範囲
        /// </summary>
        [SerializeField]
        List<TargetPointRadius> _targetPoints = new List<TargetPointRadius>();

        /// <summary>
        /// (0,0)を起点とした上向きの場合の対象座標と各地点の半径リスト
        /// </summary>
        protected Dictionary<Vector2, int> targetPointRadiuses
               => _targetPointRadiuses ??
               (_targetPointRadiuses = _targetPoints.Where(point => !point.exclusion).ToDictionary());
        /// <summary>
        /// (0,0)を起点とした上向きの場合の対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, int> _targetPointRadiuses = null;

        /// <summary>
        /// (0,0)を起点とした上向きの場合の除外対象座標と各地点の半径リスト
        /// </summary>
        protected Dictionary<Vector2, int> excludePointRadiuses
                 => _excludePointRadiuses ??
                 (_excludePointRadiuses = _targetPoints.Where(point => point.exclusion).ToDictionary());
        /// <summary>
        /// (0,0)を起点とした上向きの場合の除外対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, int> _excludePointRadiuses = null;

        /// <summary>
        /// 対象マスの列挙
        /// </summary>
        /// <param name="_basePoint">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <returns>対象マス一覧</returns>
        public List<Vector2> EnumerateTargetPointList(Vector2? _basePoint = null)
            => targetPointRadiuses
            .Select(vectorRadius => CalcBasePoint(vectorRadius, _basePoint ?? Vector2.zero))
            .SelectMany(vectorRadius => GetRoundRange(vectorRadius))
            .Where(vector => !IsInclude(excludePointRadiuses, vector))
            .ToList();

        KeyValuePair<Vector2, int> CalcBasePoint(KeyValuePair<Vector2, int> origin, Vector2 _basePoint)
            => new KeyValuePair<Vector2, int>(origin.Key - _basePoint, origin.Value);
        IEnumerable<Vector2> GetRoundRange(KeyValuePair<Vector2, int> vectorRadius)
            => GetDiameterLine(vectorRadius.Value)
            .SelectMany(_ => GetDiameterLine(vectorRadius.Value), (x, y) => new Vector2(x, y))
            .Where(vector => vector.magnitude <= vectorRadius.Value + 0.5f)
            .Select(vector => vectorRadius.Key + vector);
        IEnumerable<int> GetDiameterLine(int radius) => Enumerable.Range(-radius, radius * 2 + 1);

        /// <summary>
        /// 指定された座標が範囲に含まれるか否か判定する
        /// </summary>
        /// <param name="_target">指定座標</param>
        /// <param name="_basePoint">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <returns>指定された座標が範囲に含まれていればTrue</returns>
        public bool OnTarget(Vector2 _target, Vector2? _basePoint = null)
        {
            var basePoint = _basePoint ?? Vector2.zero;
            var target = _target - basePoint;

            return IsInclude(targetPointRadiuses, target)
                && !IsInclude(excludePointRadiuses, target);
        }

        bool IsInclude(Dictionary<Vector2, int> pointRadiuses, Vector2 target)
            => pointRadiuses
            .Any(vectorRadius => (target - vectorRadius.Key).magnitude <= vectorRadius.Value);
    }
}
