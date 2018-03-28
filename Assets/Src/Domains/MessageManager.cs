﻿using System;
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
        /// <returns>ログファイル名</returns>
        public static string LeaveLog(this LogHub logger, string logedText, IFileManager fileManager)
        {
            var displayedSentences = $"{DateTime.Now.ToLongTimeString()}\t【{logger.ToString()}】\t{logedText}";
            Debug.Log(displayedSentences);

            var path = $"{Application.dataPath}/Logs";
            var filename = $"{DateTime.Today.ToString("yyyyMMdd")}.log";
            fileManager.Write(path, filename, displayedSentences, true);
            return filename;
        }
    }
}
