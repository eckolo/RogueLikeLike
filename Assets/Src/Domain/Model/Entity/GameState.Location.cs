using System.Collections.Generic;
using UnityEngine;
using Assets.Src.Domain.Model.Value;
using Assets.Src.Domain.Service;
using System;

namespace Assets.Src.Domain.Model.Entity
{
    public partial class GameState
    {
        /// <summary>
        /// 所在地情報
        /// </summary>
        [Serializable]
        class Location
        {
            /// <summary>
            /// 上方向の方角
            /// </summary>
            [SerializeField]
            Direction _upwardDirection = Direction.NORTH;
            /// <summary>
            /// 上方向の方角
            /// </summary>
            public Direction upwardDirection { get { return _upwardDirection; } set { _upwardDirection = value; } }

            /// <summary>
            /// 全エリアデータ
            /// </summary>
            [SerializeField]
            List<Area> _areaList = new List<Area>();
            /// <summary>
            /// 全エリアデータ
            /// </summary>
            public List<Area> areaList { get { return _areaList; } set { _areaList = value; } }

            /// <summary>
            /// 現在のエリア情報
            /// </summary>
            public Area nowArea
            {
                get {
                    if(!areaList.ContainsIndex(_nowAreaNum)) return null;
                    return areaList[_nowAreaNum];
                }
                set {
                    if(!areaList.Contains(value)) areaList.Add(value);
                    _nowAreaNum = areaList.IndexOf(value);
                }
            }
            /// <summary>
            /// 所在エリア番号
            /// </summary>
            [SerializeField]
            int _nowAreaNum = 0;
        }
    }
}
