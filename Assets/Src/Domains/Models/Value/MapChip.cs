using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 1マスごとのステータスを持つマップチップオブジェクト
    /// </summary>
    [Serializable]
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
