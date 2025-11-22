using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    static public DataManager dataManager;
    public string playerNameInput;

     const string File_path = "/saveData.json";

    
    void Awake()
    {
        if(dataManager != null)
        {
              Destroy(gameObject);
              return;
        }
     
        dataManager =  this;
        DontDestroyOnLoad(dataManager);
    }
    [System.Serializable]

    class SaveData : MonoBehaviour
    {
        public string playerNameInput;

        void Start()
        {
            
        }


        
    }

    public void SaveFiles()
    {
        SaveData data = new SaveData();

        data.playerNameInput =  playerNameInput;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + File_path ,json);
        Debug.Log(json);
        

    }
    public void LoadFiles()
    {
        string path = Application.persistentDataPath + File_path;

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData dataRecived = JsonUtility.FromJson<SaveData>(json);
            playerNameInput = dataRecived.playerNameInput;
           
        }
    }

    static void IndexPlayerScore(string[] playerList)
    {
        foreach(string player in playerList)
        {
            
        }
    }

    



    
}

