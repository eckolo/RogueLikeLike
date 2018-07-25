using Assets.Src.Domains.Models.Value;
using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// 乱数関係のサービスクラス
    /// </summary>
    public static class RandomManager
    {
        /// <summary>
        /// 選択基準値を新規生成する
        /// </summary>
        /// <param name="seed">乱数の種</param>
        /// <param name="radix">基準値の母数値</param>
        /// <returns>選択基準値</returns>
        public static Fraction SetupRandomNorm(this Random.State seed, int radix = 100)
        {
            Random.state = seed;
            return Random.Range(0, radix - 1).DividedBy(radix);
        }
    }
}
