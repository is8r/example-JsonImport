using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JsonImport;

public class Example : MonoBehaviour
{
    void Start()
    {
        //普通の使い方
        GameData gameData = Resources.Load<GameData>("GameDataMaster");
        print(gameData.master.monsters.Count);

        //GameDataLoaderを経由した簡単な使い方
        print(GameDataLoader.Entity.monsters.Count);
        print(GameDataLoader.Entity.monsters[0].name);
    }
}
