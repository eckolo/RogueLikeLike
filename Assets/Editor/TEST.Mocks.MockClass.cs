using Assets.Src.Domains.Models.Interface;
using System;
using UnityEngine;

public static partial class TEST
{
    partial class Mocks
    {
        /// <summary>
        /// ただ値を持つだけのクラスのモック
        /// </summary>
        [Serializable]
        public class MockClass : IDuplicatable<MockClass>
        {
            [SerializeField]
            public string text1 = "";
            [SerializeField]
            public string text2 = "";
            [SerializeField]
            public int number = 0;
            [SerializeField]
            public InnerMockClass innerClass = new InnerMockClass();

            [Serializable]
            public class InnerMockClass
            {
                [SerializeField]
                public string text1 = "";
                [SerializeField]
                public string text2 = "";
                [SerializeField]
                public int number = 0;
            }

            /// <summary>
            /// シャローコピーメソッド
            /// </summary>
            /// <returns>コピーされたオブジェクト</returns>
            public MockClass MemberwiseClonePublic() => (MockClass)MemberwiseClone();
        }
    }
}
