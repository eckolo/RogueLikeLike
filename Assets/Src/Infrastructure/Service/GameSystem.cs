using System;
using System.Collections;

namespace Assets.Src.Infrastructure.Service
{
    /// <summary>
    /// ゲーム的な基礎動作の制御
    /// </summary>
    public static class GameSystem
    {
        /// <summary>
        /// 指定条件を満たすまで待機する関数
        /// yield returnで呼び出さないと意味をなさない
        /// </summary>
        /// <param name="endCondition">継続条件</param>
        /// <returns>イテレータ</returns>
        public static IEnumerator Wait(this Func<bool> endCondition)
        {
            while(endCondition()) yield return null;
            yield break;
        }
    }
}
