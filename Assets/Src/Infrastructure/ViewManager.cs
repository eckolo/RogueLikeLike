using Assets.Src.Domains;
using Assets.Src.Models;
using Assets.Src.Models.Areas;
using Assets.Src.Models.Npcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// 画面表示とか周りの処理クラス
    /// </summary>
    public class ViewManager : IViewManager
    {
        /// <summary>
        /// 現在のマップ状況を画面に反映する
        /// </summary>
        /// <param name="map">反映元マップデータ</param>
        /// <param name="topDirection">画面上方向の方角</param>
        /// <returns>更新処理成否</returns>
        public bool ReflectMap(Map map, Direction topDirection = Direction.NORTH)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// キャラクターのアクションを画面に反映する
        /// </summary>
        /// <param name="person">動作主体キャラクター</param>
        /// <param name="behavior">アクション内容</param>
        /// <returns>描画処理成否</returns>
        public bool ReflectAction(Npc person, PersonBehavior behavior)
        {
            throw new NotImplementedException();
        }
    }
}
