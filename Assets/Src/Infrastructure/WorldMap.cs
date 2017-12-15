using Assets.Src.Domains;
using Assets.Src.Models.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// 世界地図リポジトリ
    /// </summary>
    public partial class WorldMap : IRepository<AreaRoot, AreaIndex>
    {
        /// <summary>
        /// 地域データ読み出し関数
        /// </summary>
        /// <param name="key">読み出しデータの索引キー</param>
        /// <returns>読みだされた地域データ</returns>
        public AreaRoot GetContests(AreaIndex key)
        {
            if(!_areaList.ContainsKey(key)) return default(AreaRoot);
            return _areaList[key];
        }
        /// <summary>
        /// 地域データ削除関数
        /// </summary>
        /// <param name="key">削除データの索引キー</param>
        /// <returns>削除成否</returns>
        public bool DeleteContests(AreaIndex key)
        {
            return true;
        }
        /// <summary>
        /// 地域データの再生成
        /// </summary>
        /// <param name="setedAreaData">再生成時に生成される地域データ</param>
        /// <param name="key">再生成対象データ索引キー</param>
        /// <returns>再生成された地域データ</returns>
        public AreaRoot ResetContests(AreaRoot setedAreaData, AreaIndex key = null)
        {
            return _areaList[key];
        }

        /// <summary>
        /// 地図データ実体
        /// </summary>
        Dictionary<AreaIndex, AreaRoot> _areaList = new Dictionary<AreaIndex, AreaRoot>();
    }
}
