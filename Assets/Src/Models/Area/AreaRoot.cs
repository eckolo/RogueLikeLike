using Assets.Src.Models.Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Models
{
    /// <summary>
    /// 地域オブジェクトルート
    /// </summary>
    public class AreaRoot : AreaStationery
    {
        /// <summary>
        /// 他地域との接続情報
        /// </summary>
        public List<AreaConnection> connectionList { get; set; }
        /// <summary>
        /// 内包するマップのリスト
        /// </summary>
        public List<Map> includeMapList { get; set; }
    }
}
