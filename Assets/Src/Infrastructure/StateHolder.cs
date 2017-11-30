﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Infrastructure
{
    /// <summary>
    /// 状態保持クラス
    /// シングルトンとして中身を保持する
    /// </summary>
    public class StateHolder
    {
        /// <summary>
        /// 実際のインスタンス
        /// </summary>
        static StateHolder myself = null;

        /// <summary>
        /// インスタンス生成用のプライベートなコンストラクタ
        /// </summary>
        StateHolder() { }

        /// <summary>
        /// 状態（つまりStateHolder自身）を取得する関数
        /// </summary>
        /// <returns>既にインスタンス生成されていればそれを、無ければ新規生成して返す</returns>
        public static StateHolder GetState() => myself ?? new StateHolder();
    }
}
