using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Coupon { 

    public string validDate;
    public string storeName;
    public string itemName;

    public Coupon(string validDate, string storeName, string itemName)
    {
        this.validDate = validDate;
        this.storeName = storeName;
        this.itemName = itemName;
    }

}
