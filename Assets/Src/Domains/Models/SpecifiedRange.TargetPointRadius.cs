using System;
using UnityEngine;

namespace Assets.Src.Domains.Models
{
    public partial class SpecifiedRange
    {
        /// <summary>
        /// 位置と半径の組
        /// </summary>
        [Serializable]
        class TargetPointRadius : IKeyValueLike<Vector2, uint>
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
            public uint value => _value;
        }
    }
}
