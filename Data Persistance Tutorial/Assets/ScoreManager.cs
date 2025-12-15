using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   static public ScoreManager scoreManager;

    
    public TextMeshProUGUI textMeshProx;
    public int p1Score;
   

    void Awake()
    {
        if(scoreManager != null)
        {
        
            Destroy(gameObject);
            return;
           
        }
        
        scoreManager = this;
         DontDestroyOnLoad(scoreManager);
    }
    void Start()
    {       DataManager.dataManager.LoadFiles();
        textMeshProx.text =  $"{DataManager.dataManager.playerNameInput}: {DataManager.dataManager.playerScore}";
    }



}
