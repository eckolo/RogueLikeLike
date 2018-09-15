using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;
using Assets.Src.Domains.Service;

namespace Assets.Src.Domains.Repository
{
    /// <summary>
    /// Json形式でセーブできるクラスを提供します。
    /// </summary>
    /// <remarks>
    /// 最初に値を設定、取得するタイミングでファイル読み出します。
    /// </remarks>
    public static class SaveDataRepository
    {
        /// <summary>
        /// SingletonなSaveDatabaseクラス
        /// </summary>
        private static SaveDataBase _savedatabase = null;

        #region Public Static Methods

        static SaveDataBase GetSavedatabase(this IFileManager fileManager)
        {
            if(_savedatabase == null)
            {
                string path = $"{Application.dataPath}/";
                string fileName = $"{Application.productName}.save";
                _savedatabase = new SaveDataBase(fileManager, path, fileName);
            }
            return _savedatabase;
        }

        /// <summary>
        /// 指定したキーとType型のクラスコレクションをセーブデータに追加します。
        /// </summary>
        /// <typeparam name="Type">ジェネリッククラス</typeparam>
        /// <param name="key">キー</param>
        /// <param name="list">Type型のList</param>
        /// <exception cref="ArgumentException"></exception>
        /// <remarks>指定したキーとType型のクラスコレクションをセーブデータに追加します。</remarks>
        public static void SetList<Type>(this IFileManager fileManager, string key, List<Type> list)
            => fileManager.GetSavedatabase().SetList(key, list);

        /// <summary>
        /// 指定したキーとType型のクラスコレクションをセーブデータから取得します。
        /// </summary>
        /// <typeparam name="Type">ジェネリッククラス</typeparam>
        /// <param name="key">キー</param>
        /// <param name="_default">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static List<Type> GetList<Type>(this IFileManager fileManager, string key, List<Type> _default)
            => fileManager.GetSavedatabase().GetList(key, _default) ?? _default;

        /// <summary>
        ///  指定したキーとType型のクラスをセーブデータに追加します。
        /// </summary>
        /// <typeparam name="Type">ジェネリッククラス</typeparam>
        /// <param name="key">キー</param>
        /// <param name="_default">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static Type GetClass<Type>(this IFileManager fileManager, string key, Type _default)
            where Type : class
            => fileManager.GetSavedatabase().GetClass(key, _default);

        /// <summary>
        ///  指定したキーとType型のクラスコレクションをセーブデータから取得します。
        /// </summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void SetClass<Type>(this IFileManager fileManager, string key, Type obj) where Type : class
            => fileManager.GetSavedatabase().SetClass(key, obj);

        /// <summary>
        /// 指定されたキーに関連付けられている値を取得します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <exception cref="ArgumentException"></exception>
        public static void SetString(this IFileManager fileManager, string key, string value)
            => fileManager.GetSavedatabase().SetString(key, value);

        /// <summary>
        /// 指定されたキーに関連付けられているString型の値を取得します。
        /// 値がない場合、_defaultの値を返します。省略した場合、空の文字列を返します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="_default">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static string GetString(this IFileManager fileManager, string key, string _default = "")
            => fileManager.GetSavedatabase().GetString(key, _default);

        /// <summary>
        /// 指定されたキーに関連付けられているInt型の値を取得します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        public static void SetInt(this IFileManager fileManager, string key, int value)
            => fileManager.GetSavedatabase().SetInt(key, value);

        /// <summary>
        /// 指定されたキーに関連付けられているInt型の値を取得します。
        /// 値がない場合、_defaultの値を返します。省略した場合、0を返します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="_default">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static int GetInt(this IFileManager fileManager, string key, int _default = 0)
            => fileManager.GetSavedatabase().GetInt(key, _default);

        /// <summary>
        /// 指定されたキーに関連付けられているfloat型の値を取得します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        public static void SetFloat(this IFileManager fileManager, string key, float value)
            => fileManager.GetSavedatabase().SetFloat(key, value);

        /// <summary>
        /// 指定されたキーに関連付けられているfloat型の値を取得します。
        /// 値がない場合、_defaultの値を返します。省略した場合、0.0fを返します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="_default">デフォルトの値</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static float GetFloat(this IFileManager fileManager, string key, float _default = 0.0f) => fileManager.GetSavedatabase().GetFloat(key, _default);

        /// <summary>
        /// セーブデータからすべてのキーと値を削除します。
        /// </summary>
        public static void Clear(this IFileManager fileManager) => fileManager.GetSavedatabase().Clear();

        /// <summary>
        /// 指定したキーを持つ値を セーブデータから削除します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <exception cref="ArgumentException"></exception>
        public static void Remove(this IFileManager fileManager, string key)
            => fileManager.GetSavedatabase().Remove(key);

        /// <summary>
        /// セーブデータ内にキーが存在するかを取得します。
        /// </summary>
        /// <param name="_key">キー</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static bool ContainsKey(this IFileManager fileManager, string _key)
            => fileManager.GetSavedatabase().ContainsKey(_key);

        /// <summary>
        /// セーブデータに格納されたキーの一覧を取得します。
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public static List<string> Keys(this IFileManager fileManager) => fileManager.GetSavedatabase().Keys();

        /// <summary>
        /// 明示的にファイルに書き込みます。
        /// </summary>
        public static void Save(this IFileManager fileManager) => fileManager.GetSavedatabase().Save(fileManager);

        /// <summary>
        /// 明示的にファイルを読み込みます。
        /// </summary>
        public static void Load(this IFileManager fileManager) => fileManager.GetSavedatabase().Load(fileManager);

        #endregion

        #region SaveDatabase Class

        [Serializable]
        private class SaveDataBase
        {
            #region Fields

            private string _path;
            //保存先
            public string path
            {
                get { return _path; }
                set { _path = value; }
            }

            private string _fileName;
            //ファイル名
            public string fileName
            {
                get { return _fileName; }
                set { _fileName = value; }
            }

            private Dictionary<string, string> saveDictionary;
            //keyとjson文字列を格納

            #endregion

            #region Constructor&Destructor

            public SaveDataBase(IFileManager fileManager, string _path, string _fileName)
            {
                this._path = _path;
                this._fileName = _fileName;
                saveDictionary = new Dictionary<string, string>();
                Load(fileManager);
            }

            #endregion

            #region Public Methods

            public void SetList<Type>(string key, List<Type> list)
            {
                CheckKey(key);
                var serializableList = new Serialization<Type>(list);
                string json = JsonUtility.ToJson(serializableList);
                saveDictionary[key] = json;
            }

            public List<Type> GetList<Type>(string key, List<Type> _default)
            {
                CheckKey(key);
                if(!saveDictionary.ContainsKey(key)) return _default;
                string json = saveDictionary[key];
                Serialization<Type> deserializeList = JsonUtility.FromJson<Serialization<Type>>(json);

                return deserializeList?.ToList() ?? _default;
            }

            public Type GetClass<Type>(string key, Type _default) where Type : class
            {
                CheckKey(key);
                if(!saveDictionary.ContainsKey(key)) return _default;

                string json = saveDictionary[key];
                Type obj = JsonUtility.FromJson<Type>(json);
                return obj;
            }

            public void SetClass<Type>(string key, Type obj) where Type : class
            {
                CheckKey(key);
                string json = JsonUtility.ToJson(obj);
                saveDictionary[key] = json;
            }

            public void SetString(string key, string value)
            {
                CheckKey(key);
                saveDictionary[key] = value;
            }

            public string GetString(string key, string _default)
            {
                CheckKey(key);

                if(!saveDictionary.ContainsKey(key)) return _default;
                return saveDictionary[key];
            }

            public void SetInt(string key, int value)
            {
                CheckKey(key);
                saveDictionary[key] = value.ToString();
            }

            public int GetInt(string key, int _default)
            {
                CheckKey(key);
                if(!saveDictionary.ContainsKey(key)) return _default;

                int result;
                if(!int.TryParse(saveDictionary[key], out result)) result = 0;
                return result;
            }

            public void SetFloat(string key, float value)
            {
                CheckKey(key);
                saveDictionary[key] = value.ToString();
            }

            public float GetFloat(string key, float _default)
            {
                CheckKey(key);
                if(!saveDictionary.ContainsKey(key)) return _default;

                float result;
                if(!float.TryParse(saveDictionary[key], out result)) result = 0.0f;
                return result;
            }

            public void Clear()
            {
                saveDictionary.Clear();
            }

            public void Remove(string key)
            {
                CheckKey(key);
                if(saveDictionary.ContainsKey(key)) saveDictionary.Remove(key);
            }

            public bool ContainsKey(string _key) => saveDictionary.ContainsKey(_key);

            public List<string> Keys() => saveDictionary.Keys.ToList();

            public void Save(IFileManager fileManager)
            {
                var serialDict = new Serialization<string, string>(saveDictionary);
                serialDict.OnBeforeSerialize();
                var dictJsonString = JsonUtility.ToJson(serialDict);
                var writeText = Debug.isDebugBuild ? dictJsonString : dictJsonString.EncodeCrypt();
                fileManager.Write(_path, _fileName, writeText, false);
            }

            public void Load(IFileManager fileManager)
            {
                var readText = fileManager.Read(_path, _fileName);
                if(readText != null)
                {
                    if(saveDictionary != null)
                    {
                        var jsonText = Debug.isDebugBuild ? readText : readText.DecodeCrypt();
                        var sDict = JsonUtility.FromJson<Serialization<string, string>>(jsonText);
                        if(sDict != null)
                        {
                            sDict.OnAfterDeserialize();
                            saveDictionary = sDict.ToDictionary();
                        }
                        else
                        {
                            saveDictionary = new Dictionary<string, string>();
                        }
                    }
                }
                else
                {
                    saveDictionary = new Dictionary<string, string>();
                }
            }

            public string GetJsonString(string key)
            {
                CheckKey(key);
                if(saveDictionary.ContainsKey(key))
                {
                    return saveDictionary[key];
                }
                else
                {
                    return null;
                }
            }

            #endregion

            #region Private Methods

            /// <summary>
            /// キーに不正がないかチェックします。
            /// </summary>
            private void CheckKey(string _key)
            {
                if(string.IsNullOrEmpty(_key)) throw new ArgumentException("invalid key!!");
            }

            #endregion
        }

        #endregion

        #region Serialization Class

        // List<Type>
        [Serializable]
        private class Serialization<Type>
        {
            public List<Type> target;

            public List<Type> ToList() => target;

            public Serialization()
            {
            }

            public Serialization(List<Type> target)
            {
                this.target = target;
            }
        }
        // Dictionary<TKey, TValue>
        [Serializable]
        private class Serialization<TKey, TValue>
        {
            public List<TKey> keys;
            public List<TValue> values;
            private Dictionary<TKey, TValue> target;

            public Dictionary<TKey, TValue> ToDictionary() => target;

            public Serialization()
            {
            }

            public Serialization(Dictionary<TKey, TValue> target)
            {
                this.target = target;
            }

            public void OnBeforeSerialize()
            {
                keys = new List<TKey>(target.Keys);
                values = new List<TValue>(target.Values);
            }

            public void OnAfterDeserialize()
            {
                int count = Math.Min(keys.Count, values.Count);
                target = new Dictionary<TKey, TValue>(count);
                Enumerable.Range(0, count).ToList().ForEach(i => target.Add(keys[i], values[i]));
            }
        }

        #endregion
    }
}