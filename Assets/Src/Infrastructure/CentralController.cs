using UnityEngine;
using System.Collections;
using Assets.Src.Domains;

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
            LogHub.TRACE.LeaveLog($"{typeof(CentralController).FullName} StartUp");
            PrefabManager.SetObject<CentralController>();
        }

        /// <summary>
        /// オブジェクト生成直後に呼ばれるコールバック
        /// </summary>
        void Awake()
        {
            LogHub.TRACE.LeaveLog($"{typeof(CentralController).FullName} Awake");
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
            var gameStates = GameStates.GetNowState(new InjectedMethods
            {
                viewer = new ViewManager(),
                skillRepository = new SkillRepository()
            });
            while(true)
            {
                gameStates = gameStates.PerformTurnByTurn();
            }
        }
        /// <summary>
        /// メインルーチンがのっているコルーチン保持変数
        /// </summary>
        Coroutine mainThread = default(Coroutine);
    }
}
