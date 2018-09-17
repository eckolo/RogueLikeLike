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
        protected IEnumerable<MapChip> setableMapChipList => _setableMapChips;

        /// <summary>
        /// 発生し得るイベントリスト
        /// </summary>
        [SerializeField]
        List<MapEvent> _mapEvents = new List<MapEvent>();
        /// <summary>
        /// 発生し得るイベントリスト
        /// </summary>
        protected IEnumerable<MapEvent> mapEventList => _mapEvents;
    }
}
