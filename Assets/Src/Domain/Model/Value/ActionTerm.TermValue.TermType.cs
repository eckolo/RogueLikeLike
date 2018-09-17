namespace Assets.Src.Domain.Model.Value
{
    public partial class ActionTerm
    {
        partial class TermValue
        {
            /// <summary>
            /// どういった形の条件判定がなされるかの種類
            /// </summary>
            public enum TermType
            {
                /// <summary>
                /// 等しい
                /// </summary>
                EQUAL,
                /// <summary>
                /// 未満
                /// </summary>
                LESS_THAN,
                /// <summary>
                /// より大きい
                /// </summary>
                GREATER_THAN,
                /// <summary>
                /// 以下
                /// </summary>
                LESS_THAN_OR_EQUAL,
                /// <summary>
                /// 以上
                /// </summary>
                GREATER_THAN_OR_EQUAL,
            }
        }
    }
}
