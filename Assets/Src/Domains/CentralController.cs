using UnityEngine;
using System.Collections;
using System;

namespace Assets.Src.Domains
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
            Debug.Log("CentralController StartUp");
            new GameObject("CentralController", typeof(CentralController));
        }

        /// <summary>
        /// オブジェクト生成直後に呼ばれるコールバック
        /// </summary>
        void Awake()
        {
            Debug.Log("CentralController Awake");
            SetUp();
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        /// <returns>初期処理正常完了フラグ</returns>
        bool SetUp()
        {
            if(mainThread == default(Coroutine)) mainThread = StartCoroutine(IntroductionMainRoutine());
            return true;
        }

        /// <summary>
        /// メインルーチン制御への導入
        /// </summary>
        /// <returns>イテレータ</returns>
        IEnumerator IntroductionMainRoutine()
        {
            while(true)
            {
                RogueLikeManager.PerformTurnByTurn();
            }
        }
        /// <summary>
        /// メインルーチンがのっているコルーチン保持変数
        /// </summary>
        Coroutine mainThread = default(Coroutine);
    }
}
