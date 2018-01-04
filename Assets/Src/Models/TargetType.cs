namespace Assets.Src.Models
{
    /// <summary>
    /// 動作対象の種類
    /// </summary>
    public enum TargetType
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
        /// 最も近い友好NPC
        /// </summary>
        NEAR_FRIEND,
        /// <summary>
        /// 最も近い敵対NPC
        /// </summary>
        NEAR_STRANGER,
        /// <summary>
        /// 最も遠いNPC
        /// </summary>
        AWAY,
        /// <summary>
        /// 最も遠い友好NPC
        /// </summary>
        AWAY_FRIEND,
        /// <summary>
        /// 最も遠い敵対NPC
        /// </summary>
        AWAY_STRANGER,
        /// <summary>
        /// 最も強いNPC
        /// </summary>
        STRONG,
        /// <summary>
        /// 最も強い友好NPC
        /// </summary>
        STRONG_FRIEND,
        /// <summary>
        /// 最も強い敵対NPC
        /// </summary>
        STRONG_STRANGER,
        /// <summary>
        /// 最も弱いNPC
        /// </summary>
        WEAK,
        /// <summary>
        /// 最も弱い友好NPC
        /// </summary>
        WEAK_FRIEND,
        /// <summary>
        /// 最も弱い敵対NPC
        /// </summary>
        WEAK_STRANGER,
        /// <summary>
        /// 最も元気なNPC
        /// </summary>
        LIVELY,
        /// <summary>
        /// 最も元気な友好NPC
        /// </summary>
        LIVELY_FRIEND,
        /// <summary>
        /// 最も元気な敵対NPC
        /// </summary>
        LIVELY_STRANGER,
        /// <summary>
        /// 最も弱っているNPC
        /// </summary>
        WEAKENED,
        /// <summary>
        /// 最も弱っている友好NPC
        /// </summary>
        WEAKENED_FRIEND,
        /// <summary>
        /// 最も弱っている敵対NPC
        /// </summary>
        WEAKENED_STRANGER,
    }
}
