using Assets.Src.Domains.Models.Abstract;
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
            private string _text1 = "";
            public string text1 { get { return _text1; } set { _text1 = value; } }
            [SerializeField]
            private string _text2 = "";
            public string text2 { get { return _text2; } set { _text2 = value; } }
            [SerializeField]
            private int _number = 0;
            public int number { get { return _number; } set { _number = value; } }
            [SerializeField]
            private InnerMockClass _innerClass = new InnerMockClass();
            public InnerMockClass innerClass { get { return _innerClass; } set { _innerClass = value; } }

            [Serializable]
            public class InnerMockClass
            {
                [SerializeField]
                private string _text1 = "";
                public string text1 { get { return _text1; } set { _text1 = value; } }
                [SerializeField]
                private string _text2 = "";
                public string text2 { get { return _text2; } set { _text2 = value; } }
                [SerializeField]
                private int _number = 0;
                public int number { get { return _number; } set { _number = value; } }
            }

            /// <summary>
            /// シャローコピーメソッド
            /// </summary>
            /// <returns>コピーされたオブジェクト</returns>
            public MockClass MemberwiseClonePublic() => (MockClass)MemberwiseClone();
        }
    }
}
