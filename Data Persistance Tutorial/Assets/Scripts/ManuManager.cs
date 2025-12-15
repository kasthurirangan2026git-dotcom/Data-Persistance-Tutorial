using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.Android.Gradle.Manifest;
using System;
using TMPro.Examples;
using TMPro;
using UnityEditor.Overlays;






#if UNITY_EDITOR
using UnityEditor;
#endif

public class ManuManager : MonoBehaviour 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
[SerializeField]
    InputField playerNameInput;

    public TextMeshProUGUI text;

    Vector3 pos = new Vector3(115, 933,0);

    void Awake()
    {
       
    }
    void Start()
    {
        
    }



    public void StartGame()
    {

        DataManager.dataManager.playerNameInput = playerNameInput.text;
        string x = DataManager.dataManager.playerNameInput;
        Debug.Log(x);
        DataManager.dataManager.savePlayerName();
        SceneManager.LoadScene(1);
        text.rectTransform.transform.position =  pos;


    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }
   
}
