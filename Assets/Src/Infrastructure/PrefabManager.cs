﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// プレファブなどの実体化されたオブジェクト類の管理クラス
    /// </summary>
    public static class PrefabManager
    {
        /// <summary>
        /// ゲームオブジェクトの新規作成
        /// </summary>
        /// <typeparam name="Prefab">作成されるオブジェクトに実装される型</typeparam>
        /// <param name="objectName">オブジェクト名称</param>
        /// <returns>生成されたオブジェクト</returns>
        public static Prefab SetObject<Prefab>(this string objectName) where Prefab : MonoBehaviour
            => new GameObject(objectName, typeof(Prefab)).GetComponent<Prefab>();
        /// <summary>
        /// ゲームオブジェクトの新規作成
        /// 型名をそのままオブジェクト名とする
        /// </summary>
        /// <typeparam name="Prefab">作成されるオブジェクトに実装される型</typeparam>
        /// <returns>生成されたオブジェクト</returns>
        public static Prefab SetObject<Prefab>() where Prefab : MonoBehaviour
            => typeof(Prefab).FullName.SetObject<Prefab>();

        /// <summary>
        /// ゲームオブジェクトに親オブジェクトを設定して返す
        /// </summary>
        /// <typeparam name="Prefab">ゲームオブジェクト型</typeparam>
        /// <typeparam name="Parent">親のオブジェクト型</typeparam>
        /// <param name="prefab">ゲームオブジェクト</param>
        /// <param name="parent">親のオブジェクト</param>
        /// <returns>親の設定されたゲームオブジェクトk</returns>
        public static Prefab SetParent<Prefab, Parent>(this Prefab prefab, Parent parent = null)
            where Prefab : MonoBehaviour
            where Parent : MonoBehaviour
        {
            prefab.transform.SetParent(parent.transform);
            return prefab;
        }
    }
}
