using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MissionStart : MonoBehaviour
{
   
    //public int[] missionStoreIndexArray = new int[4];
    public Text[] buttonText;

    public StoreInfoManager storeInfoManager; //StoreInfo를 받아오기 위해 있는 애 

    void Start()
    {

        for (int i = 0; i < storeInfoManager.missionStoreIndexArray.Length; i++)
        {
            storeInfoManager.missionStoreIndexArray[i] = Random.Range(0, 12);
            bool isSame = false;

            for(int j=0; j<i; j++)
            {
                if (storeInfoManager.missionStoreIndexArray[i] == storeInfoManager.missionStoreIndexArray[j])
                {
                    isSame = true;
                    i--;
                    break;
                }
            }
            if (isSame == true) continue;
           

        }
        for(int a =0; a < 4; a++)
        {
            buttonText[a].text = storeInfoManager.storeInfos[storeInfoManager.missionStoreIndexArray[a]].storeName;
        }
        
    }





    ////public int[] missionStoreIndexArray = new int[4];
    //public Text[] buttonText;

    //public StoreInfoManager storeInfoManager; //StoreInfo를 받아오기 위해 있는 애 
   
    //void Start()
    //{
       
    //    for (int i = 0; i < storeInfoManager.missionStoreIndexArray.Length; i++)
    //    {
    //        storeInfoManager.missionStoreIndexArray[i] = Random.Range(0, 13);
    //        buttonText[i].text = storeInfoManager.storeInfos[storeInfoManager.missionStoreIndexArray[i]].storeName;

    //    }
    //}
 
}
