using System;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    static public DataManager dataManager;
    public string playerNameInput;


    public int playerScore ;

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

    class SaveData
    {
        public string playerNameInput;
       public int playerScore;
        
    }

    

    public void SaveFiles()
    {

      
        SaveData data = new SaveData();

        data.playerNameInput = playerNameInput;
        data.playerScore = playerScore;
        

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + File_path ,json);
        Debug.Log(data.playerNameInput );
        

    }
    public void LoadFiles()
    {
        string path = Application.persistentDataPath + File_path;

        if (File.Exists(path))
        {
            SaveData data = new SaveData();
            string json = File.ReadAllText(path);
            SaveData dataRecived = JsonUtility.FromJson<SaveData>(json);
            playerNameInput = dataRecived.playerNameInput;
            playerScore = dataRecived.playerScore;
            Debug.Log(playerNameInput + playerScore );
        }
    }

     public void savePlayerName()
    {
        SaveData data = new SaveData();
        data.playerNameInput = $"{playerNameInput}: {playerScore}"  ;

    }

     public void savePlayerInfo()
    {
        SaveData data = new SaveData();
        data.playerNameInput = $"{playerNameInput}: {playerScore}"  ;

    }


    



    
}

