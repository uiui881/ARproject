using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class MissionCompleted : MonoBehaviour
{
    public StoreInfoManager storeInfoManager;
    public CouponInfoManager couponInfoManager;
    public Text informText;
    public string storeName;
    public string validTime;
    public string giftItem;
    public string[] Gift = new string[]{"10% 할인쿠폰", "건어물 1팩", "육포 1팩", "닭강정 쿠폰","5천원 식사권", "마늘 1봉지","소금 1봉지","15% 할인 쿠폰","강냉이 1봉지","돌자반 1팩"};
    void Start()
    {
        
        storeInfoManager = GameObject.Find("StoreInfoManager").GetComponent<StoreInfoManager>();
        storeName = storeInfoManager.storeInfos[storeInfoManager.missionStoreIndexArray[UnityEngine.Random.Range(0, 4)]].storeName;
        validTime = DateTime.Today.AddDays(30).ToString("yyyy-MM-dd");
        giftItem = Gift[UnityEngine.Random.Range(0,10)];
        informText.text = "오늘의 상점 [ " + storeName + " ] 에서 " + giftItem+ " 를 받아가세요!!";
        Coupon coupon = new Coupon(validTime, storeName, giftItem);
        couponInfoManager.Add(coupon);

    }

}













//public class MissionCompleted : MonoBehaviour
//{
//    public StoreInfoManager storeInfoManager;
//    public CouponInfoManager couponInfoManager;
//    public Text informText;
//    public string storeName;
//    public string validTime;

//    void Start()
//    {
//        storeInfoManager = GameObject.Find("StoreInfoManager").GetComponent<StoreInfoManager>();

//        storeName = storeInfoManager.storeInfos[storeInfoManager.missionStoreIndexArray[UnityEngine.Random.Range(0, 4)]].storeName;
//        informText.text = "오늘의 상점 [ " + storeName + " ] 에서 " + "부채를 받아가세요!!";
//        validTime = DateTime.Today.AddDays(30).ToString("yyyy-MM-dd");
//        couponInfoManager.couponList.Add(new Coupon(validTime, storeName, "부채"));

//    }
//}