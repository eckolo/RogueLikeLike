namespace Assets.Src.Domains.Models.Value
{
    public partial class Skill
    {
        /// <summary>
        /// スキルの分類
        /// </summary>
        public enum Section
        {
            /// <summary>
            /// 心
            /// </summary>
            SPIRIT = 0,
            /// <summary>
            /// 技
            /// </summary>
            TECHNIQUE = 1,
            /// <summary>
            /// 体
            /// </summary>
            BODY = 2
        }
    }
}
