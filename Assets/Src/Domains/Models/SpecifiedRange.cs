using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains.Models
{
    /// <summary>
    /// 詳細なマス目指定の範囲指定
    /// </summary>
    [Serializable]
    public partial class SpecifiedRange
    {
        [SerializeField]
        List<TargetPointRadius> _targetPoints = new List<TargetPointRadius>();

        /// <summary>
        /// (0,0)を起点とした上向きの場合の対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, uint> targetPointRadiusList
            => _targetPointRadiusList ?? (_targetPointRadiusList = _targetPoints.ToDictionary());

        /// <summary>
        /// (0,0)を起点とした上向きの場合の対象座標と各地点の半径リスト
        /// </summary>
        Dictionary<Vector2, uint> _targetPointRadiusList = null;

        /// <summary>
        /// 対象マスの列挙
        /// </summary>
        /// <param name="_basePoint">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <returns>対象マス一覧</returns>
        public List<Vector2> EnumerateTargetPointList(Vector2? _basePoint = null)
            => targetPointRadiusList.SelectMany(vectorRadius => GetRoundRange(vectorRadius)).ToList();

        List<Vector2> GetRoundRange(KeyValuePair<Vector2, uint> vectorRadius)
        {
            var result = new List<Vector2>();
            var basePoint = vectorRadius.Key;
            var radius = (int)vectorRadius.Value;
            var limit = radius + 0.5f;
            for(int pointDiffX = -radius; pointDiffX <= radius; pointDiffX++)
            {
                for(int pointDiffY = -radius; pointDiffY <= radius; pointDiffY++)
                {
                    var pointDiff = new Vector2(pointDiffX, pointDiffY);
                    var vector = basePoint + pointDiff;

                    if((vector - basePoint).magnitude <= limit) result.Add(vector);
                }
            }
            return result;
        }

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

            return targetPointRadiusList
                .Any(vectorRadius => (target - vectorRadius.Key).magnitude <= vectorRadius.Value);
        }
    }
}
