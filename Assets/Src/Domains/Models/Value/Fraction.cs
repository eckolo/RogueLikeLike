using Assets.Src.Domains.Service;
using System;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 正確な分数を表現するクラス
    /// </summary>
    public class Fraction : IComparable<Fraction>, IComparable<int>, IComparable<float>
    {
        /// <summary>
        /// 分数の初期化
        /// </summary>
        /// <param name="_numer">分子</param>
        /// <param name="_denom">分母</param>
        public Fraction(int _numer, int _denom = 1)
        {
            var gcd = (_denom < 0 ? -1 : 1) * _numer.Euclidean(_denom);
            this._numer = _numer / gcd;
            this._denom = _denom / gcd;
        }

        /// <summary>
        /// 分子
        /// </summary>
        readonly int _numer;
        /// <summary>
        /// 分子
        /// </summary>
        public int numer => _numer;
        /// <summary>
        /// 分母
        /// </summary>
        readonly int _denom;
        /// <summary>
        /// 分母
        /// </summary>
        public int denom => _denom;
        /// <summary>
        /// 実数値
        /// </summary>
        public float value => _numer / (float)_denom;

        public static Fraction operator +(Fraction x, Fraction y)
            => new Fraction(x._numer * y._denom + y._numer * x._denom, x._denom * y._denom);
        public static Fraction operator -(Fraction x, Fraction y)
            => new Fraction(x._numer * y._denom - y._numer * x._denom, x._denom * y._denom);
        public static Fraction operator *(Fraction x, Fraction y)
            => new Fraction(x._numer * y._numer, x._denom * y._denom);
        public static Fraction operator /(Fraction x, Fraction y)
            => new Fraction(x._numer * y._denom, x._denom * y._numer);
        public static Fraction operator +(int x, Fraction y) => new Fraction(x) + y;
        public static Fraction operator +(Fraction x, int y) => x + new Fraction(y);
        public static Fraction operator -(int x, Fraction y) => new Fraction(x) - y;
        public static Fraction operator -(Fraction x, int y) => x - new Fraction(y);
        public static Fraction operator *(int x, Fraction y) => new Fraction(x) * y;
        public static Fraction operator *(Fraction x, int y) => x * new Fraction(y);
        public static Fraction operator /(int x, Fraction y) => new Fraction(x) / y;
        public static Fraction operator /(Fraction x, int y) => x / new Fraction(y);

        public int CompareTo(Fraction other)
        {
            if(_numer * other._denom > other._numer * _denom) return 1;
            if(_numer * other._denom < other._numer * _denom) return -1;
            return 0;
        }
        public int CompareTo(int other) => CompareTo(new Fraction(other));
        public int CompareTo(float other)
        {
            if(_numer > other * _denom) return 1;
            if(_numer < other * _denom) return -1;
            return 0;
        }
    }
}
