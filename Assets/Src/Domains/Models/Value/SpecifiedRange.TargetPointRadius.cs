using Assets.Src.Domains.Models.Interface;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    public partial class SpecifiedRange
    {
        /// <summary>
        /// 位置と半径の組
        /// </summary>
        [Serializable]
        class TargetPointRadius : IKeyValueLike<Vector2, int>
        {
            /// <summary>
            /// 位置座標
            /// </summary>
            [SerializeField]
            Vector2 _key = new Vector2();
            /// <summary>
            /// 位置座標
            /// </summary>
            public Vector2 key => _key;

            /// <summary>
            /// 半径
            /// </summary>
            [SerializeField]
            uint _value = default(uint);
            /// <summary>
            /// 半径
            /// </summary>
            public int value => (int)_value;

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
}
