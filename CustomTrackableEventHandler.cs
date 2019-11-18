using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    public int num;
    public GameObject infoFinding;

    public MissionController missionController;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound(); //상점을 발견했다.

        //infoFinding.SetActive(true);

            //이거 액티브 시켜야함

        missionController.getNum(num);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        infoFinding.SetActive(false);
    }
}
