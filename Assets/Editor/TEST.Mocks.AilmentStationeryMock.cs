using System.Collections.Generic;
using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using UnityEngine;

public static partial class TEST
{
    partial class Mocks
    {
        /// <summary>
        /// <see cref="Ailment">を利用するテスト用のモック
        /// </summary>
        public class AilmentStationeryMock : Ailment.Stationery
        {
            public AilmentStationeryMock()
            {
            }
        }
    }
}
