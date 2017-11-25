using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Area
{
    /// <summary>
    /// マップオブジェクト
    /// </summary>
    public class Map
    {
        /// <summary>
        /// 地域内座標
        /// </summary>
        public Vector2 coordinate { get; set; }

        /// <summary>
        /// 発生イベント
        /// </summary>
        public MapEvent occurMapEvent { get; set; }
    }
}
