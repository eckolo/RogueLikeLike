using Assets.Src.Domains.Models.Abstract;
using Assets.Src.Domains.Models.Value;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
        public static IEnumerable<TSource> MaxKeys<TSource, TComparable>(this IEnumerable<TSource> source, System.Func<TSource, TComparable> selector)
            where TComparable : System.IComparable<TComparable>
        {
            var maxValue = source.Max(selector);
            return source.Where(elem => selector(elem).CompareTo(maxValue) == 0);
        }
        /// <summary>
        /// リストから所定の最小値を持つ要素を抽出する
        /// </summary>
        /// <typeparam name="TSource">リストを構成する要素型</typeparam>
        /// <typeparam name="TComparable">最小値判定時の型</typeparam>
        /// <param name="source">元リスト</param>
        /// <param name="selector">最小値判定値算出関数</param>
        /// <returns></returns>
        public static IEnumerable<TSource> MinKeys<TSource, TComparable>(this IEnumerable<TSource> source, System.Func<TSource, TComparable> selector)
            where TComparable : System.IComparable<TComparable>
        {
            var minValue = source.Min(selector);
            return source.Where(elem => selector(elem).CompareTo(minValue) == 0);
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
        /// 辞書型オブジェクトが所定のキーを含んでいればキーに紐づく値、含んでいなければデフォルト値を取得する
        /// </summary>
        /// <typeparam name="TKey">キ－型</typeparam>
        /// <typeparam name="TValue">内容型</typeparam>
        /// <param name="origin">取得対象の辞書型オブジェクト</param>
        /// <param name="key">指定のキー</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>所定のキーに紐づく値もしくはデフォルト値</returns>
        public static TValue GetOrDefault<TKey, TValue>(
            this Dictionary<TKey, TValue> origin,
            TKey key,
            TValue defaultValue = default(TValue))
            => origin.ContainsKey(key) ? origin[key] : defaultValue;

        /// <summary>
        /// ある数値が<see cref="List{T}">のインデックスとして正当か否か判定する
        /// </summary>
        /// <typeparam name="TValue">内容型</typeparam>
        /// <param name="origin">判定対象のリスト</param>
        /// <param name="index">判定対象のインデックス</param>
        /// <returns>指定した数値がリストのインデックスに含まれているか否か</returns>
        public static bool ContainsIndex<TValue>(this List<TValue> origin, int index)
            => 0 <= index && index < origin.Count;

        /// <summary>
        /// リストから選択基準値に基づき1要素を抜き出す
        /// </summary>
        /// <typeparam name="TValue">リストの要素型</typeparam>
        /// <param name="values">選択されるリストのセット</param>
        /// <param name="norm">選択基準値</param>
        /// <param name="rates">確率分布</param>
        /// <returns>選択された値</returns>
        public static TValue Pick<TValue>(this IEnumerable<TValue> values, Fraction norm, List<int> rates = null)
        {
            rates = rates ?? values.Select(_ => 1).ToList();
            var ratevalues = rates.Zip(values, (rate, value) => new KeyValuePair<int, TValue>(rate, value));
            var selection = ratevalues.Sum(ratevalue => Mathf.Max(ratevalue.Key, 0)) * norm;
            if(selection < 0) return default(TValue);
            foreach(var ratevalue in ratevalues)
            {
                selection -= ratevalue.Key;
                if(selection < 0) return ratevalue.Value;
            }
            return default(TValue);
        }
        /// <summary>
        /// リストから乱数シード値に基づき無作為1要素を抜き出す
        /// </summary>
        /// <typeparam name="TValue">リストの要素型</typeparam>
        /// <param name="values">選択されるリストのセット</param>
        /// <param name="seed">乱数シード値</param>
        /// <param name="rates">確率分布</param>
        /// <returns>選択された値</returns>
        public static TValue Pick<TValue>(this IEnumerable<TValue> values, Random.State seed, List<int> rates = null)
            => values.Pick(seed.SetupRandomNorm(rates?.Sum() ?? values.Count()), rates);
    }
}
