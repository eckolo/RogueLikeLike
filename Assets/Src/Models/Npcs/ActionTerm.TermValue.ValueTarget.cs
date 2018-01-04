namespace Assets.Src.Models.Npcs
{
    public partial class ActionTerm
    {
        partial class TermValue
        {
            /// <summary>
            /// 条件判定値取得対象の種類
            /// </summary>
            public enum ValueTarget
            {
                /// <summary>
                /// 自身
                /// </summary>
                MYSELF,
                /// <summary>
                /// 最も近いNPC
                /// </summary>
                NEAR,
                /// <summary>
                /// 最も遠いNPC
                /// </summary>
                AWAY,
                /// <summary>
                /// 最も近い友好NPC
                /// </summary>
                NEAR_FRIEND,
                /// <summary>
                /// 最も遠い友好NPC
                /// </summary>
                AWAY_FRIEND,
                /// <summary>
                /// 最も近い敵対NPC
                /// </summary>
                NEAR_STRANGER,
                /// <summary>
                /// 最も遠い敵対NPC
                /// </summary>
                AWAY_STRANGER,
            }
        }
    }
}
