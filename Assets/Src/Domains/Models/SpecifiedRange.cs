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
    public class SpecifiedRange
    {
        /// <summary>
        /// (0,0)を起点とした上向きの場合の対象座標リスト
        /// </summary>
        [SerializeField]
        List<Vector2> _targetPointList = new List<Vector2>();

        /// <summary>
        /// 実範囲の半径指定値
        /// </summary>
        int radius = 0;

        /// <summary>
        /// 対象マスの列挙
        /// </summary>
        /// <param name="_basePoint">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <returns>対象マス一覧</returns>
        public List<Vector2> EnumerateTargetPointList(Vector2? _basePoint = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定された座標が範囲に含まれるか否か判定する
        /// </summary>
        /// <param name="target">指定座標</param>
        /// <param name="_basePoint">
        /// 範囲指定の起点となる座標
        /// 未指定時は(0,0)となる
        /// </param>
        /// <returns>指定された座標が範囲に含まれていればTrue</returns>
        public bool OnTarget(Vector2 target, Vector2? _basePoint = null)
        {
            throw new NotImplementedException();
        }
    }
}
