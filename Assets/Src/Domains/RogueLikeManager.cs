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
        /// <param name="states">内部ステータス集合</param>
        /// <param name="methods">インフラメソッド集合</param>
        /// <returns>内部ステータス</returns>
        public static GameStates PerformTurnByTurn(this GameStates states)
        {
            states.map = states.SetupNextMap();
            return states;
        }
    }
}
