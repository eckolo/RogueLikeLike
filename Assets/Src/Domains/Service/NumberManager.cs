using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// 数値計算用クラス
    /// </summary>
    public static class NumberManager
    {
        /// <summary>
        /// 最大公約数を求める
        /// </summary>
        /// <param name="x">公約数を求める対象その１</param>
        /// <param name="y">公約数を求める対象その２</param>
        /// <returns>２引数の最大公約数</returns>
        public static int Euclidean(this int x, int y)
        {
            if(x == 0) return 1;
            if(y == 0) return 1;
            var absX = Mathf.Abs(x);
            var absY = Mathf.Abs(y);
            if(absY > absX) return Euclidean(absY, absX);
            if(absX % absY == 0) return y;
            return Euclidean(absY, absX % y);
        }
        /// <summary>
        /// mainの数値をsubに合わせて補正する
        /// </summary>
        /// <param name="main">元値</param>
        /// <param name="sub">補正値</param>
        /// <param name="degree">元値への寄せ度合い</param>
        /// <returns>補正済みの値</returns>
        public static float Correct(this float main, float sub, float degree = 0.5f)
            => main * degree + sub * (1 - degree);
    }
}
