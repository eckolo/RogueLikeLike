using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// 状態保持オブジェクトのインターフェース
    /// </summary>
    public interface IGameFoundation : IDuplicatable<IGameFoundation>
    {
        /// <summary>
        /// インフラアクセスメソッド群アクセス用インターフェース
        /// </summary>
        InjectedMethods methods { get; }

        /// <summary>
        /// パラメータ一括アクセス用プロパティ
        /// </summary>
        GameState nowState { get; set; }
        /// <summary>
        /// 画面反映待ちキュー
        /// </summary>
        Queue<Happened> viewQueue { get; }

        /// <summary>
        /// 乱数の種
        /// </summary>
        Random.State nowSeed { get; }

        /// <summary>
        /// 全エリアデータ
        /// </summary>
        List<Area> areaList { get; }
        /// <summary>
        /// 現在の地域データ
        /// </summary>
        Area nowArea { get; set; }
        /// <summary>
        /// 現在のマップデータ
        /// </summary>
        Map nowMap { get; set; }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        Vector2 nowMapCondition { get; set; }

        /// <summary>
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        IEnumerable<Npc> nowNpcList { get; }
    }
}
