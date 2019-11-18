using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class CouponInfoList
{
    //public List<Coupon> list = new List<Coupon>();
    public List<Coupon> list;
}
public class CouponInfoManager : MonoBehaviour
{
    public CouponInfoList couponList;

    public void Load()
    {
        string couponJsonData = PlayerPrefs.GetString("DB2", "");
        Debug.Log(couponJsonData);

        if (couponJsonData.Length <= 0)
        {
            Debug.Log(1);
            couponList = new CouponInfoList();
            couponList.list = new List<Coupon>();
            //if (couponList == null)
            return;
        }

        couponList = JsonUtility.FromJson<CouponInfoList>(couponJsonData);
        Debug.Log("copon list count : " + couponList.list.Count);
    }

    public void Add(Coupon coupon)
    {
        Load();
        couponList.list.Add(coupon);
        Save();
    }

    public void Save()
    {
        string couponJsonData = JsonUtility.ToJson(couponList);
        PlayerPrefs.SetString("DB2", couponJsonData);
        PlayerPrefs.Save();
    }
}
