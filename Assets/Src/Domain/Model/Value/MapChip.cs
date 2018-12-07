using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 1マスごとのステータスを持つマップチップオブジェクト
    /// </summary>
    [Serializable]
    public partial class MapChip : ScriptableObject
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

        /// <summary>
        /// マップチップ設置層
        /// </summary>
        [SerializeField]
        Layer _layer = default(Layer);

        /// <summary>
        /// マップチップ設置Z座標補正値
        /// </summary>
        [SerializeField]
        int _layerCorrect = 0;

        /// <summary>
        /// マップチップ設置Z座標
        /// </summary>
        public int positionZ => (int)_layer + _layerCorrect;
    }
}
