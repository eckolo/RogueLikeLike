using Assets.Src.Models.Person;
using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Src.Models.Area;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 画面表示系操作インフラのインターフェース
    /// </summary>
    public interface IViewManager
    {
        /// <summary>
        /// 現在のマップ状況を画面に反映する
        /// </summary>
        /// <param name="map">反映元マップデータ</param>
        /// <param name="topDirection">画面上方向の方角</param>
        /// <returns>更新処理成否</returns>
        bool ReflectMap(Map map, Direction topDirection = Direction.NORTH);
        /// <summary>
        /// キャラクターのアクションを画面に反映する
        /// </summary>
        /// <param name="person">動作主体キャラクター</param>
        /// <param name="behavior">アクション内容</param>
        /// <returns>描画処理成否</returns>
        bool ReflectAction(Npc person, PersonBehavior behavior);
    }
}
