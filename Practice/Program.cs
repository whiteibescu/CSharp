using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using Newtonsoft.Json;

public class RelativeLstEditorScript : RelativeListbutton
{
    private void Awake()
    {
        AddTestButtonList(new Action[] {
            Test1,Test2,Test3,LoadDatabase, CreateDatabase,
        });
    }
    public void Test1() => $"Test1 : {functionIndex}".Log();
    public void Test2() => $"Test2 : {functionIndex}".Log();
    public void Test3() => $"Test3 : {functionIndex}".Log();
    public void Test4()
    {
        functionDic.Clear();
        AddTestButtonList(new Action[] {
            Test1,Test2,Test3,Test4, ()=>$"Test5 : {functionIndex}".Log()
        });
    }

    public void CreateDatabase()
    {
        GameDatabase gameDatabase = new GameDatabase();
        gameDatabase.hp = "100";
        gameDatabase.mana = "100";
        gameDatabase.name = "James";
        gameDatabase.pairData.Add("a", "red");
        var data = JsonConvert.SerializeObject(gameDatabase);
        PlayerPrefs.SetString("data", data);
    }

    public void LoadDatabase()
    {
        if (PlayerPrefs.HasKey("data"))
        {
            string jsonData = PlayerPrefs.GetString("data");
            var data = JsonConvert.DeserializeObject<GameDatabase>(jsonData);
            data.pairData.ContainsKey("a").Log();
            data.pairData.TryGetValue("a", out var a);
            a.Log();
            data.hp.Log();
            data.mana.Log();
            data.name.Log();
        }
    }
}

public class GameDatabase
{
    public string hp;
    public string mana;
    public string name;

    public Dictionary<string, string> pairData;
    public GameDatabase()
    {
        pairData = new Dictionary<string, string>();
    }
}
