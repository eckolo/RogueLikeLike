using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Domains
{
    /// <summary>
    /// ファイルの入出力制御
    /// </summary>
    public interface IFileManager
    {
        /// <summary>
        /// ファイル書き込み
        /// </summary>
        /// <param name="filename">書き込み先ファイルパス名</param>
        /// <param name="value">書き込み内容</param>
        /// <returns>書き込み成否</returns>
        bool Write(string filename, string value);
        /// <summary>
        /// ファイル読み込み
        /// </summary>
        /// <param name="filename">読み込み先ファイルパス名</param>
        /// <returns>読み込んだファイル内容</returns>
        string Read(string filename);
    }
}
