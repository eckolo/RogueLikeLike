using System;

namespace Assets.Src.Domain.Model.Value
{
    public partial class MinMax<TValue> where TValue : IComparable<TValue>
    {
        /// <summary>
        /// <see cref="MinMax{TValue}"/>クラスのビルダー
        /// </summary>
        public class Builder
        {
            TValue _min;
            TValue _max;

            bool _limitMin = false;
            bool _limitMax = false;

            /// <summary>
            /// クラス生成
            /// </summary>
            /// <returns>クラスオブジェクト</returns>
            public MinMax<TValue> Build() => new MinMax<TValue>(_min, _max, _limitMin, _limitMax);

            /// <summary>
            /// 最小値を設定する
            /// </summary>
            /// <param name="_min">最小値</param>
            /// <returns>最小値の設定されたビルダー</returns>
            public Builder Min(TValue _min)
            {
                this._min = _min;
                _limitMin = true;
                return this;
            }
            /// <summary>
            /// 最大値を設定する
            /// </summary>
            /// <param name="_max">最大値</param>
            /// <returns>最大値の設定されたビルダー</returns>
            public Builder Max(TValue _max)
            {
                this._max = _max;
                _limitMax = true;
                return this;
            }
        }
    }
}
