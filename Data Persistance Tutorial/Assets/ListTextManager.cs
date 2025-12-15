using UnityEngine;

public class ListTextManager : MonoBehaviour
{
   static public ListTextManager listTextManager;

   public GameObject ScoreBoard1;
  
    void Awake()
    {
        if(listTextManager!= null)
        {
            
            Destroy(gameObject);
            return;
           
        }
        listTextManager = this;
      
    }
}
