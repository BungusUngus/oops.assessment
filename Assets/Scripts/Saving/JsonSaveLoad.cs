using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public static class JsonSaveLoad
{


#if UNITY_EDITOR
    //persistant data path means that save data is saved in there no matter what 
    public static string file = Application.dataPath + "/saveHS.json";
    public static string filepos = Application.dataPath + "/save.json";
#else
    public static string file = Application.persistentDataPath + "/saveHS.json";
    public static string filepos = Application.persistentDataPath + "/save.json";
#endif

    public static void SaveHighScore(HighScoreData data)
    {
        string json = JsonUtility.ToJson(data,true);
        File.WriteAllText(file, json);
    }
    
    public static HighScoreData LoadHighScore()
    {
        if(File.Exists(file))
        {
            string json = File.ReadAllText(file);
            return JsonUtility.FromJson<HighScoreData>(json);
        }
        return null;
    }







    public static void Save(GameData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(filepos, json);
    }

    public static GameData Load()
    {
        if (File.Exists(filepos))
        {
            string json = File.ReadAllText(filepos);
            return JsonUtility.FromJson<GameData>(json);
        }

        return null;
    }
}
