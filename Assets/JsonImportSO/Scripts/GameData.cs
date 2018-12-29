using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JsonImport
{
    //ScriptableObject作成
    [CreateAssetMenu]
    public class GameData : ScriptableObject
    {
        public GameMasterData master;
    }

    //シート毎のデータ形式
    [Serializable]
    public class GameMasterData
    {
        public List<MonsterItem> monsters = new List<MonsterItem>();
    }

    //行毎のデータ形式
    [Serializable]
    public class MonsterItem
    {
        public int id;
        public string name;
        public string description;
        public int hp;
        public int gold;
    }
}
