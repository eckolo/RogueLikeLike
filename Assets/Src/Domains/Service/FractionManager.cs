using Assets.Src.Domains.Models.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// <see cref="Fraction"/>クラスを扱うサービス
    /// </summary>
    public static class FractionManager
    {
        /// <summary>
        /// 割り算形式での分数型生成メソッド
        /// </summary>
        /// <param name="dividend">被除数</param>
        /// <param name="divisor">除数</param>
        /// <returns>被除数を除数で割った結果と同値の分数型の値</returns>
        public static Fraction DividedBy(this int dividend, int divisor) => Fraction.Of(dividend) / divisor;

        /// <summary>
        /// 上限値をかける
        /// </summary>
        /// <param name="origin">元の値</param>
        /// <param name="upper">上限値</param>
        /// <returns>上限値以下の元の値</returns>
        public static Fraction LimitUpper(this Fraction origin, Fraction upper)
            => origin.value < upper.value ? origin : upper;

        /// <summary>
        /// 下限値をかける
        /// </summary>
        /// <param name="origin">元の値</param>
        /// <param name="upper">下限値</param>
        /// <returns>下限値以上の元の値</returns>
        public static Fraction LimitLower(this Fraction origin, Fraction lower)
            => origin.value > lower.value ? origin : lower;
    }
}
