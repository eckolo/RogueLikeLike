namespace Assets.Src.Domain.Model.Value
{
    public partial class TargetType
    {
        /// <summary>
        /// 動作対象の範囲を制限する条件種別
        /// </summary>
        public enum Limited
        {
            /// <summary>
            /// 制限無し
            /// </summary>
            NONE,
            /// <summary>
            /// 友好NPC
            /// </summary>
            FRIEND,
            /// <summary>
            /// 敵対NPC
            /// </summary>
            STRANGER,
            /// <summary>
            /// 自身
            /// </summary>
            MYSELF
        }
    }
}
