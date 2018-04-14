using Assets.Src.Domains.Service;
using System;
using System.Collections.Generic;
using Assets.Src.Domains.Models;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// 世界地図リポジトリ
    /// </summary>
    public partial class WorldMap : IRepository<int, Area>
    {
        /// <summary>
        /// 地域データ読み出し関数
        /// </summary>
        /// <param name="key">読み出しデータの索引キー</param>
        /// <returns>読みだされた地域データ</returns>
        public Area GetContests(int key)
        {
            if(!_areaList.ContainsKey(key)) return default(Area);
            return _areaList[key];
        }
        /// <summary>
        /// 地域データ削除関数
        /// </summary>
        /// <param name="key">削除データの索引キー</param>
        /// <returns>削除成否</returns>
        public bool DeleteContests(int key)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 地域データの再生成
        /// </summary>
        /// <param name="setedAreaData">再生成時に生成される地域データ</param>
        /// <param name="key">再生成対象データ索引キー</param>
        /// <returns>再生成された地域データ</returns>
        public Area ResetContests(Area setedAreaData, int key = default(int))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 地図データ実体
        /// </summary>
        Dictionary<int, Area> _areaList = new Dictionary<int, Area>();
    }
}
