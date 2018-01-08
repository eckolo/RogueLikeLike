using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// リスト関連の汎用操作クラス
    /// </summary>
    public static class EnumerableManager
    {
        /// <summary>
        /// リストから所定の最大値を持つ要素を抽出する
        /// </summary>
        /// <typeparam name="TSource">リストを構成する要素型</typeparam>
        /// <typeparam name="TComparable">最大値判定時の型</typeparam>
        /// <param name="source">元リスト</param>
        /// <param name="selector">最大値判定値算出関数</param>
        /// <returns></returns>
        public static IEnumerable<TSource> MaxKeys<TSource, TComparable>(this IEnumerable<TSource> source, Func<TSource, TComparable> selector) where TComparable : IComparable<TComparable>
        {
            var maxValue = source.Max(selector);
            return source.Where(elem => selector(elem).CompareTo(maxValue) == 0);
        }
    }
}
