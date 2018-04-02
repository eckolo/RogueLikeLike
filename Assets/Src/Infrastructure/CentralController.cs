using UnityEngine;
using System.Collections;
using Assets.Src.Domains;
using System;

namespace Assets.Src.Infrastructure
{
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
        /// 初期処理
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
                var gameStates = GameStates.CreateNewState();
                while(true)
                {
                    gameStates = gameStates.PerformTurnByTurn();
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
