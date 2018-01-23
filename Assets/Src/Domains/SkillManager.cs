using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// スキル関連サービス
    /// </summary>
    public static class SkillManager
    {
        /// <summary>
        /// スキルキークラスからリソースフォルダに検索かける際のキー文字列への変換処理
        /// </summary>
        /// <param name="key">スキルの索引キークラス</param>
        /// <returns>検索キーとなる文字列</returns>
        public static string ToFileName(this SkillKey key) => $"{(int)key}_{key.ToString().ConvertSnakeToPascal()}";
    }
}
