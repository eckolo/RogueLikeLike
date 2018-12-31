using System;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// ある値の範囲を示すクラス
    /// </summary>
    public partial class MinMax<TValue> where TValue : IComparable<TValue>
    {
        /// <summary>
        /// ビルダーの生成
        /// </summary>
        public static Builder builder => new Builder();

        MinMax(TValue _min, TValue _max, bool _limitMin, bool _limitMax)
        {
            if(_limitMin && _limitMax && _min.CompareTo(_max) > 0) throw new ArgumentOutOfRangeException();

            this._min = _min;
            this._max = _max;
            this._limitMin = _limitMin;
            this._limitMax = _limitMax;
        }

        /// <summary>
        /// 最小値
        /// </summary>
        readonly TValue _min;
        /// <summary>
        /// 最小値
        /// </summary>
        public TValue min => _limitMin ? _min : default;

        /// <summary>
        /// 最大値
        /// </summary>
        readonly TValue _max;
        /// <summary>
        /// 最大値
        /// </summary>
        public TValue max => _limitMax ? _max : default;

        /// <summary>
        /// 最小値が設定されているか否か
        /// </summary>
        readonly bool _limitMin = false;
        /// <summary>
        /// 最大値が設定されているか否か
        /// </summary>
        readonly bool _limitMax = false;
    }
}
