using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CouponController : MonoBehaviour
{
    public CouponInfoManager couponInfoManager;
    public Text[] contextText;
  

    public Transform contentTrans;
    public GameObject ButtonPrefab;
    public GameObject nothingButton;
    void Start()
    {

        //PlayerPrefs.DeleteAll();
        float posY = 900f;

        nothingButton.SetActive(true);

         couponInfoManager.Load();

        for (int i=0; i < couponInfoManager.couponList.list.Count; i++)
        {
            nothingButton.SetActive(false);
            GameObject button = Instantiate(ButtonPrefab, Vector2.zero, Quaternion.identity, contentTrans);
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, posY);
            posY -= 200f;

            Text contentText = button.GetComponentsInChildren<Text>()[1];
            contentText.text = couponInfoManager.couponList.list[i].validDate + "  " + couponInfoManager.couponList.list[i].storeName + "  " + couponInfoManager.couponList.list[i].itemName;

        }
    }
}



//public class CouponController : MonoBehaviour
//{
//    public CouponInfoManager couponInfoManager;
//    // public Text[] contextText;
//    //public GameObject[] buttonArray;

//    public Transform contentTrans;
//    public GameObject ButtonPrefab;
//    public GameObject nothingButton;
//    void Start()
//    {
//        float posY = 0;
//        GameObject couponInfoMngGameObject = GameObject.Find("CouponInfoManager");
//        if (couponInfoMngGameObject == null) return;
//        couponInfoManager = couponInfoMngGameObject.GetComponent<CouponInfoManager>();
//        nothingButton.SetActive(true);


//        for (int i = 0; i < couponInfoManager.couponList.Count; i++)
//        {
//            nothingButton.SetActive(false);
//            GameObject button = Instantiate(ButtonPrefab, Vector2.zero, Quaternion.identity, contentTrans);
//            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 900f);
//            posY -= 200f;

//            Text contentText = button.GetComponentsInChildren<Text>()[1];
//            contentText.text = couponInfoManager.couponList[i].validDate + "  " + couponInfoManager.couponList[i].storeName + "  " + couponInfoManager.couponList[i].itemName;

//        }
//    }
//}