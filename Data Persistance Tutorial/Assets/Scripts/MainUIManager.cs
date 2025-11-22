using UnityEngine;

public class PlayerScoreListManager : MonoBehaviour
{   public static  PlayerScoreListManager playerScore_; 
    public string playerName ;
     string playerNameInList = $""; 
     int playerMax = 3;
    public int score;
     string[] playerList;




     string test ;
     

     

     void Start()
    {

     
    
          playerList = new string[playerMax];

         for (int i = 0; i< playerMax; i++)
        {
            switch (i)
            {
                case 0:
                playerNameInList = $"first: {playerName}: {score}";
                break;
                case 1:
                playerNameInList = $"second: {playerName}: {score}";
                break;
                case 2:
                playerNameInList = $"third: {playerName}: {score}";
                break;
                
            }
               
          playerList[i] = playerNameInList;

          
        }
          foreach(string x in playerList)
                    { test += x;
                         Debug.Log(x);
                    }

    }


}
