using UnityEngine;
using System.Collections;

namespace Assets.Src.Domains
{
    public class CentralController : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            Debug.Log("Start");
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("Update");
        }

        /// <summary>
        /// 最初期起動関数
        /// とりあえず自己生成するだけ
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void StartUp()
        {
            Debug.Log("StartUp");
            new GameObject("CentralController", typeof(CentralController));
        }
    }
}
