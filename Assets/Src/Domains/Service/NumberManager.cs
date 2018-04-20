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
    }
}
