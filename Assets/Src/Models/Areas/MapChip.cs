﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Models.Areas
{
    /// <summary>
    /// 1マスごとのステータスを持つマップチップオブジェクト
    /// </summary>
    public class MapChip : ScriptableObject
    {
        /// <summary>
        /// 地形リスト
        /// </summary>
        [SerializeField]
        List<MapTerrain> _terrains = null;
        /// <summary>
        /// 地形リスト
        /// </summary>
        public IEnumerable<MapTerrain> terrainList => _terrains;
    }
}
