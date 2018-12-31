using Assets.Src.Domain.Model.Abstract;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 地域雛形オブジェクト
    /// </summary>
    [Serializable]
    public class AreaStationery : Named
    {
        /// <summary>
        /// 設置され得るマップチップリスト
        /// </summary>
        [SerializeField]
        List<MapChip> _setableMapChips = new List<MapChip>();
        /// <summary>
        /// 設置され得るマップチップリスト
        /// </summary>
        public IEnumerable<MapChip> setableMapChipList => _setableMapChips;

        /// <summary>
        /// 発生し得るイベントリスト
        /// </summary>
        [SerializeField]
        List<MapEventArrangement> _mapEvents = new List<MapEventArrangement>();
        /// <summary>
        /// 発生し得るイベントリスト
        /// </summary>
        public IEnumerable<MapEventArrangement> mapEvents => _mapEvents;

        /// <summary>
        /// エリア中の通行不能域発生率
        /// </summary>
        [SerializeField]
        int _wallIncidence = 0;
        /// <summary>
        /// エリア中の通行不能域発生率
        /// </summary>
        public int wallIncidence => _wallIncidence;

        /// <summary>
        /// エリア横幅（マップ数）の最小値
        /// </summary>
        [SerializeField]
        int _widthMin = 1;
        /// <summary>
        /// エリア横幅（マップ数）の最小値
        /// </summary>
        [SerializeField]
        int _widthMax = 1;

        /// <summary>
        /// エリア横幅（マップ数）の範囲
        /// </summary>
        public MinMax<int> widthRange
            => MinMax<int>.builder.Min(_widthMin).Max(_widthMax).Build();

        /// <summary>
        /// エリア縦幅（マップ数）の最小値
        /// </summary>
        [SerializeField]
        int _heightMin = 1;
        /// <summary>
        /// エリア縦幅（マップ数）の最小値
        /// </summary>
        [SerializeField]
        int _heightMax = 1;

        /// <summary>
        /// エリア縦幅（マップ数）の範囲
        /// </summary>
        public MinMax<int> heightRange
            => MinMax<int>.builder.Min(_heightMin).Max(_heightMax).Build();
    }
}
