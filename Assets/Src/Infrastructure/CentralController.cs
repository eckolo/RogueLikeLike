using Assets.Src.Domains.Service;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// システム的なゲーム処理統括
    /// </summary>
    public class CentralController : MonoBehaviour
    {
        /// <summary>
        /// 最初期起動関数
        /// とりあえず自己生成するだけ
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void StartUp()
        {
            LogHub.TRACE.LeaveLog($"{typeof(CentralController).FullName} StartUp", new FileManager());
            PrefabManager.SetObject<CentralController>();
        }

        /// <summary>
        /// オブジェクト生成直後に呼ばれるコールバック
        /// </summary>
        void Awake()
        {
            LogHub.TRACE.LeaveLog($"{typeof(CentralController).FullName} Awake", new FileManager());
            SetUp();
        }

        /// <summary>
        /// システム的な初期処理
        /// </summary>
        /// <returns>初期処理正常完了フラグ</returns>
        bool SetUp()
        {
            viewRoot = viewRoot ?? PrefabManager.SetObject<ViewRoot>().SetParent(this);

            if(mainThread == default(Coroutine)) mainThread = StartCoroutine(IntroductionMainRoutine());
            return true;
        }
        ViewRoot viewRoot = null;

        /// <summary>
        /// メインルーチン制御への導入
        /// </summary>
        /// <returns>イテレータ</returns>
        IEnumerator IntroductionMainRoutine()
        {
            try
            {
                var gameFoundation = GameFoundation.CreateNewState(DateTime.Now.GetHashCode());
                gameFoundation = (GameFoundation)gameFoundation.ExecuteOpening();
                while(true)
                {
                    gameFoundation = (GameFoundation)gameFoundation.ExecuteTurnByTurn();
                    LogHub.DEBUG.LeaveLog($"{gameFoundation.nowState} TurnByTurn", new FileManager());
                }
            }
            catch(Exception error)
            {
                LogHub.ERROR.LeaveLog(error.ToString(), new FileManager());
                throw error;
            }
        }
        /// <summary>
        /// メインルーチンがのっているコルーチン保持変数
        /// </summary>
        Coroutine mainThread = default(Coroutine);
    }
}
