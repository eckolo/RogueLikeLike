using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains
{
    /// <summary>
    /// ログとか画面文字表示管轄クラス
    /// </summary>
    public static partial class MessageManager
    {
        /// <summary>
        /// ログを残す
        /// </summary>
        /// <param name="logger">ログの種類</param>
        /// <param name="logedText">ログに残されるべきテキスト</param>
        /// <returns></returns>
        public static string LeaveLog(this LogHub logger, string logedText)
        {
            var displayedSentences = $"【{logger.ToString()}】{logedText}";
            Debug.Log(displayedSentences);
            return displayedSentences;
        }
    }
}
