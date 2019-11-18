using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreInfoManager : MonoBehaviour
{
   
    public Store[] storeInfos;
    public int[] missionStoreIndexArray = new int[4];
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
