﻿using UnityEngine;
using System.Collections;
using System;
using Assets.Src.Infrastructure;

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
            Debug.Log($"{typeof(CentralController).FullName} StartUp");
            PrefabManager.SetObject<CentralController>();
        }

        /// <summary>
        /// オブジェクト生成直後に呼ばれるコールバック
        /// </summary>
        void Awake()
        {
            Debug.Log($"{typeof(CentralController).FullName} Awake");
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
