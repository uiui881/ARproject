using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class MissionController : MonoBehaviour
{
    //StoreInfoManager storeInfoManager = (StoreInfoManager) GameObject.Find("storeInfoManager");

    public GameObject findingInfo;
    public Image[] Boxes;
    public Image[] Panels;
    public Toggle[] storeToggles;
    public Text[] toggleText;
    public StoreInfoManager storeInfoManager;
    public AudioClip popUpSound;
    AudioSource popUpAudio;

    public GameObject[] stampPictures;
    public Image[] stamps;
    public bool[] setActiveState = {false,false,false,false};

    int inventory = 0;
    ArrayList checkList = new ArrayList();

    public void Start()
    {
        storeInfoManager = GameObject.Find("StoreInfoManager").GetComponent<StoreInfoManager>();

        findingInfo.SetActive(false);
        for (int i = 0; i < 4; i++)
        {
            int num = storeInfoManager.missionStoreIndexArray[i];
            Panels[i].sprite = storeInfoManager.storeInfos[num].storeImage;
            stamps[i].sprite = storeInfoManager.storeInfos[num].storeImage;//
            stampPictures[i].SetActive(false);//
            toggleText[i].text = storeInfoManager.storeInfos[storeInfoManager.missionStoreIndexArray[i]].storeName;
            storeToggles[i].isOn = false;
            popUpAudio = findingInfo.GetComponent<AudioSource>();
        }
        
    }

    public void getNum(int num)
    {
        for (int a = 0; a < 4; a++)
        {
            if (storeInfoManager.missionStoreIndexArray[a] == num)
            {
                findingInfo.SetActive(true);
                stampPictures[a].SetActive(true); 
                setActiveState[a] = true;
                Boxes[a].sprite = storeInfoManager.storeInfos[num].storeImage;//얘를 건드려야하는데
                storeToggles[a].isOn = true;
                popUpAudio.Play();

                if (!checkList.Contains(num))
                {
                    checkList.Add(num);
                    inventory++;
                }
            }
            if (inventory == 4)
            {
                StartCoroutine(forSucceedScene());
            }
        }
    }

    IEnumerator forSucceedScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("SucceedScene");
    }

    private void Update()
    {
        for(int i = 0; i < 4; i++)
        {
            if (setActiveState[i] == true)
            {
                stampPictures[i].transform.position = Vector3.MoveTowards(stampPictures[i].transform.position, Boxes[i].transform.position, 10f);
                stampPictures[i].transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);

                if(Vector3.Distance(stampPictures[i].transform.position, Boxes[i].transform.position)<0.1f){
                    setActiveState[i] = false;
                    stampPictures[i].SetActive(false);
      
                }
            }
        }
        
    }
}
