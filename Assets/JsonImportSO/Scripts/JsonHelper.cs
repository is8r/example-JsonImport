/*
from: http://eggame.hateblo.jp/entry/2017/10/03/185946
*/

using UnityEngine;
using System;
using System.IO;
using System.Text;

namespace JsonImport
{
    public class JsonHelper
    {
        /// <summary>
        /// JSONファイルをStringで読み込みます。
        /// </summary>
        /// <param name="filePath">streamingAssetsフォルダからのパス</param>
        /// <param name="fileName">ファイル名</param>
        /// <returns>jsonのstringデータ</returns>
        public static String GetJsonFile(String filePath, String fileName, bool isDebug = false)
        {
            string fileText = "";

            // Jsonファイルを読み込む
            FileInfo fi = new FileInfo(Application.streamingAssetsPath + filePath + fileName);
            try
            {
                // 一行毎読み込み
                using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8))
                {
                    fileText = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                // 改行コード
                fileText += e + "\n";
            }

            if(isDebug)
            {
                Debug.Log(fileText);
            }

            return fileText;
        }
    }
}