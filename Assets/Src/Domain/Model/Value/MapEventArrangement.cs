using System;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// マップイベントの発生率や発生傾向など含めた定義クラス
    /// </summary>
    [Serializable]
    public class MapEventArrangement
    {
        /// <summary>
        /// 対応イベント
        /// </summary>
        [SerializeField]
        MapEvent _mapEvent = null;
        /// <summary>
        /// 対応イベント
        /// </summary>
        public MapEvent mapEvent => _mapEvent;

        /// <summary>
        /// イベント発生の必須マップレベル
        /// </summary>
        [SerializeField]
        int _minLevel = 0;
        /// <summary>
        /// イベント発生の必須マップレベル
        /// </summary>
        public int minLevel => _minLevel;

        /// <summary>
        /// イベント発生率
        /// </summary>
        [SerializeField]
        Percentage _occurPercent = Percentage.one;
        /// <summary>
        /// イベント発生率
        /// </summary>
        public Percentage occurPercent => _occurPercent;

        /// <summary>
        /// イベント発生率のマップレベル比例値
        /// </summary>
        [SerializeField]
        Percentage _occurPercentForLevel = Percentage.zero;
        /// <summary>
        /// イベント発生率のマップレベル比例値
        /// </summary>
        public Percentage occurPercentForLevel => _occurPercentForLevel;
    }
}
