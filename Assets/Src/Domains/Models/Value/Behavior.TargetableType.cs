﻿namespace Assets.Src.Domains.Models.Value
{
    public partial class Behavior
    {
        /// <summary>
        /// ターゲット可能対象パターン
        /// </summary>
        public enum TargetableType
        {
            /// <summary>
            /// ターゲット可能対象無し
            /// 対象無し作動可能
            /// </summary>
            NO_TARGET,
            /// <summary>
            /// 自分自身のみ
            /// </summary>
            MYSELF,
            /// <summary>
            /// 自分以外
            /// </summary>
            OTHER_MYSELF,
            /// <summary>
            /// 全ての物体
            /// </summary>
            ALL,
        }
    }
}
