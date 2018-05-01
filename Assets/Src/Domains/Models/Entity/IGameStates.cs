﻿using Assets.Src.Domains.Models.Interface;
using Assets.Src.Domains.Models.Value;
using Assets.Src.Domains.Service;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Entity
{
    /// <summary>
    /// 状態保持オブジェクトのインターフェース
    /// </summary>
    public interface IGameStates : IDuplicatable<IGameStates>
    {
        /// <summary>
        /// インフラアクセスメソッド群アクセス用インターフェース
        /// </summary>
        InjectedMethods methods { get; }

        /// <summary>
        /// パラメータ一括アクセス用プロパティ
        /// </summary>
        GameStateEntity stateEntity { get; set; }
        /// <summary>
        /// 画面反映待ちキュー
        /// </summary>
        Queue<Happened> viewQueue { get; }

        /// <summary>
        /// 乱数の種
        /// </summary>
        Random.State seed { get; }

        /// <summary>
        /// 全エリアデータ
        /// </summary>
        List<Area> areaList { get; }
        /// <summary>
        /// 現在の地域データ
        /// </summary>
        Area area { get; set; }
        /// <summary>
        /// 現在のマップデータ
        /// </summary>
        Map map { get; set; }
        /// <summary>
        /// 所在マップ座標
        /// </summary>
        Vector2 mapCondition { get; set; }

        /// <summary>
        /// 現在のマップ上に存在するNPC全体のリスト
        /// </summary>
        IEnumerable<Npc> npcList { get; }
    }
}
