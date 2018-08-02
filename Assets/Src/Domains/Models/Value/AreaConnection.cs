using Assets.Src.Domains.Models.Entity;
using System;
using UnityEngine;

namespace Assets.Src.Domains.Models.Value
{
    /// <summary>
    /// 地域接続データオブジェクト
    /// </summary>
    [Serializable]
    public class AreaConnection
    {
        /// <summary>
        /// 地域内座標
        /// </summary>
        [SerializeField]
        Vector2 _coordinate = Vector2.zero;
        /// <summary>
        /// 地域内座標
        /// </summary>
        public Vector2 coordinate { get { return _coordinate; } set { _coordinate = value; } }

        /// <summary>
        /// 接続先地域
        /// </summary>
        [SerializeField]
        Area _connectArea = null;
        /// <summary>
        /// 接続先地域
        /// </summary>
        public Area connectArea { get { return _connectArea; } set { _connectArea = value; } }

        /// <summary>
        /// 接続先地域の接続座標
        /// </summary>
        [SerializeField]
        Vector2 _connectAreaCoordinate = Vector2.zero;
        /// <summary>
        /// 接続先地域の接続座標
        /// </summary>
        public Vector2 connectAreaCoordinate
        {
            get { return _connectAreaCoordinate; }
            set { _connectAreaCoordinate = value; }
        }
    }
}
