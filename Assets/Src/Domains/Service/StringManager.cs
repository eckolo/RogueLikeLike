using System;
using System.Linq;

namespace Assets.Src.Domains.Service
{
    /// <summary>
    /// 文字列処理サービス
    /// </summary>
    public static class StringManager
    {
        /// <summary>
        /// スネークケースの英数文字列をパスカルケースに変換する
        /// </summary>
        /// <param name="origin">スネークケースと思しき元の英数文字列</param>
        /// <returns>パスカルケースな英数文字列</returns>
        public static string ConvertSnakeToPascal(this string origin) => origin
            .Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(text => text.First().ToString().ToUpper() + text.Substring(1).ToLower())
            .Aggregate(string.Empty, (text1, text2) => text1 + text2);
    }
}
