using Assets.Src.Models;
using Assets.Src.Models.Person;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// 各種ローグライク処理統括クラス
    /// </summary>
    public static class RogueLikeManager
    {
        /// <summary>
        /// ターン毎の処理実施
        /// </summary>
        /// <returns>処理が正常終了したか否か</returns>
        public static bool PerformTurnByTurn()
        {
            if(!GameStates.nowState.view.Update()) return false;
            return true;
        }
        /// <summary>
        /// 行動決定関数
        /// </summary>
        /// <param name="person">行動決定対象</param>
        /// <returns>行動決定処理成否</returns>
        public static bool DetermineAction(this Npc person)
        {
            return true;
        }
    }
}
