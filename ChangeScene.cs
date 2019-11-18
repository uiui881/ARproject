using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void onClickGameStartButton()
    {
        SceneManager.LoadScene("InformStoreScene");
    }

    public void onClickCouponButton()
    {
        SceneManager.LoadScene("CouponScene");
    }

    public void onClickMissionStartButton()
    {
        SceneManager.LoadScene("CameraScene");
    }

    public void onCouponExitButton()
    {
        SceneManager.LoadScene("FirstScene");
    }

}

