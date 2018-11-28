using System;
using UnityEngine;

namespace Assets.Src.Domain.Model.Value
{
    /// <summary>
    /// 百分率を表現するクラス
    /// </summary>
    [Serializable]
    public class Percentage : Fraction
    {
        public Percentage(int numer) : base(numer)
        {
            _numer = numer;
        }

        [SerializeField]
        int _numer = 0;

        public override int numer => _numer;

        public override int denom => 100;
    }
}
