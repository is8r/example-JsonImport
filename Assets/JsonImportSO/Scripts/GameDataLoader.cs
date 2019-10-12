using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace JsonImport
{
    public class GameDataLoader : MonoBehaviour
    {
        #region For Inspector

        public string fileName = "data.json";//StreamingAssets内のファイル
        public const string DATA_NAME = "GameMasterData";//Resouces内のファイル

        //jsonからResourcesにあるデータを上書きする
        public void Load()
        {
            GameData gameData = Resources.Load<GameData>(DATA_NAME);
            gameData.master = new GameMasterData();
            gameData.master = JsonUtility.FromJson<GameMasterData>(JsonHelper.GetJsonFile("/", fileName, true));

            UnityEditor.EditorUtility.SetDirty(gameData);
            Debug.Log(fileName + "をロードしました");
        }

        #endregion

        #region Reference function

        //GameDataLoaderクラス経由で参照できるように
        private static GameData entity;
        public static GameMasterData Entity
        {
            get
            {
                if (entity == null)
                {
                    entity = Resources.Load<GameData>(DATA_NAME);

                    if (entity == null)
                    {
                        Debug.LogError(DATA_NAME + " not found");
                    }
                }
                return entity.master;
            }
        }

        #endregion
    }
}