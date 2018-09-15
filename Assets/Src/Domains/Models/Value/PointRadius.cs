using Assets.Src.Domains.Models.Abstract;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 位置と半径の組
    /// </summary>
    [Serializable]
    public class PointRadius : IKeyValueLike<Vector2, int>
    {
        /// <summary>
        /// 位置座標
        /// </summary>
        [SerializeField]
        Vector2 _point = new Vector2();
        /// <summary>
        /// 位置座標
        /// </summary>
        public Vector2 key => _point;

        /// <summary>
        /// 半径
        /// </summary>
        [SerializeField]
        uint _radius = default(uint);
        /// <summary>
        /// 半径
        /// </summary>
        public int value => (int)_radius;

        /// <summary>
        /// 除外範囲であるフラグ
        /// </summary>
        [SerializeField]
        bool _exclusion = false;
        /// <summary>
        /// 除外範囲であるフラグ
        /// </summary>
        public bool exclusion => _exclusion;
    }
}
