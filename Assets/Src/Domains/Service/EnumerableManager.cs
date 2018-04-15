using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// <see cref="IEnumerable{T}">関連の汎用操作クラス
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

        /// <summary>
        /// インスペクタから管理する<see cref="IKeyValueLike{TKey, TValue}">のリストを<see cref="Dictionary{TKey, TValue}"/>に変換する
        /// </summary>
        /// <typeparam name="TKey">キ－型</typeparam>
        /// <typeparam name="TValue">内容型</typeparam>
        /// <param name="origin">変換元のKeyValueっぽいクラスのリスト</param>
        /// <returns>生成された辞書型リスト</returns>
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<IKeyValueLike<TKey, TValue>> origin)
            => origin.ToDictionary(keyValue => keyValue.key, keyValue => keyValue.value);

        /// <summary>
        /// ある数値が<see cref="List{T}">のインデックスとして正当か否か判定する
        /// </summary>
        /// <typeparam name="TValue">内容型</typeparam>
        /// <param name="origin">判定対象のリスト</param>
        /// <param name="index">判定対象のインデックス</param>
        /// <returns>指定した数値がリストのインデックスに含まれているか否か</returns>
        public static bool ContainsIndex<TValue>(this List<TValue> origin, int index)
            => 0 <= index && index < origin.Count;
    }
}
