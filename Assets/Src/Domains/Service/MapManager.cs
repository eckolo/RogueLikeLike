using Assets.Src.Domains.Models.Entity;
using Assets.Src.Domains.Models.Value;
using System.Linq;
using UnityEngine;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// Map周りの制御サービス
    /// </summary>
    public static class MapManager
    {
        /// <summary>
        /// 所定のマップにおけるNPCの存在座標の取得
        /// NPC自体存在していなければNull
        /// </summary>
        /// <param name="map">座標確認対象マップ</param>
        /// <param name="npc">座標確認したいNPC</param>
        /// <returns>座標</returns>
        public static Vector2? GetNpcCoordinate(this Map map, Npc npc)
            => map.npcList.ContainsValue(npc)
            ? map.npcList.SingleOrDefault(_npc => _npc.Value == npc).Key
            : (Vector2?)null;

        /// <summary>
        /// 所定のマップにおける2NPC間の距離を取得
        /// いずれかのNPCが存在しない場合はNull
        /// </summary>
        /// <param name="map">計算対象マップ</param>
        /// <param name="npc1">距離算出元NPCその１</param>
        /// <param name="npc2">距離算出元NPCその２</param>
        /// <returns>距離</returns>
        public static float? GetNpcsDistance(this Map map, Npc npc1, Npc npc2)
            => (map.GetNpcCoordinate(npc1) - map.GetNpcCoordinate(npc2))?.magnitude;
    }
}
