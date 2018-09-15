using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Src.Domains.Models.Abstract
{
    /// <summary>
    /// 名前付きオブジェクトの雛形
    /// </summary>
    public abstract class Named : ScriptableObject, IEquatable<Named>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public new virtual string name => base.name;

        /// <summary>
        /// 説明
        /// </summary>
        public string description => _description;
        /// <summary>
        /// 説明文章設定箇所
        /// </summary>
        [SerializeField]
        string _description = null;

        /// <summary>
        /// 値の等値比較
        /// </summary>
        /// <param name="other">比較対象</param>
        /// <returns>自身と比較対象が値として等値であるか否か</returns>
        public override bool Equals(object other)
        {
            //otherがnullか、型が違うときは、等価でない
            if(other == null || GetType() != other.GetType()) return false;
            return Equals((Named)other);
        }
        /// <summary>
        /// 値の等値比較
        /// </summary>
        /// <param name="other">比較対象</param>
        /// <returns>自身と比較対象が値として等値であるか否か</returns>
        public bool Equals(Named other) => other != null && name == other.name;

        public override int GetHashCode()
        {
            var hashCode = -1301573508;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            return hashCode;
        }

        public static bool operator ==(Named x, Named y) => x.Equals(y);
        public static bool operator !=(Named x, Named y) => !(x == y);
    }
}