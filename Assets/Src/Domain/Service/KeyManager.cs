using Assets.Src.Domain.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Src.Domain.Service
{
    /// <summary>
    /// キー入力周りの汎用制御クラス
    /// </summary>
    public static partial class KeyManager
    {
        /// <summary>
        /// 複数キーのOR押下判定
        /// </summary>
        /// <param name="keys">判定対象キー一覧</param>
        /// <param name="timing">判定対象タイミング</param>
        /// <param name="endProcess">一致キーに対する操作</param>
        /// <returns>判定結果</returns>
        public static bool Judge(this List<KeyCode> keys, KeyTiming timing = KeyTiming.DOWN, UnityAction<IEnumerable<KeyCode>> endProcess = null)
        {
            if(keys == null) return false;
            if(keys.Count <= 0) return false;
            var matchKeys = keys.Where(key => key.Judge(timing));
            endProcess?.Invoke(matchKeys);
            return timing == KeyTiming.OFF ? keys.All(key => key.Judge(timing)) : matchKeys.Any();
        }
        /// <summary>
        /// 単数キーの押下判定
        /// </summary>
        /// <param name="key">判定対象キー</param>
        /// <param name="timing">判定対象タイミング</param>
        /// <returns>判定結果</returns>
        public static bool Judge(this KeyCode key, KeyTiming timing = KeyTiming.DOWN)
        {
            switch(timing)
            {
                case KeyTiming.DOWN:
                    return Input.GetKeyDown(key);
                case KeyTiming.ON:
                    return Input.GetKey(key);
                case KeyTiming.UP:
                    return Input.GetKeyUp(key);
                case KeyTiming.OFF:
                    return !Input.GetKey(key) && !Input.GetKeyUp(key);
                default:
                    return false;
            }
        }

        /// <summary>
        /// ボタンの入力状態を整数0,1に変換
        /// テストはボタン入力エミュレートがよくわからなくて書いてないので注意
        /// </summary>
        public static int ToInt(this KeyCode buttom) => buttom.Judge(KeyTiming.ON).ToInt();
    }
}
