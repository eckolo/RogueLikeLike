using System;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// プレイヤーオブジェクト
    /// 操作可能という意味なので、複数あったり存在しなくてもよい
    /// </summary>
    [Serializable]
    public class Player : Npc
    {
    }
}
