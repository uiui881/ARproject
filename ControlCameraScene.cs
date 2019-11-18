using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlCameraScene : MonoBehaviour
{

    public GameObject panel;
    public Button StoreButton;
    public Button ExitButton;
    public bool state = false;

    public void onClickStoreButton()
    {
        state = !state;
        panel.SetActive(state);
    }
    public void onClickExitButton()
    {
        panel.SetActive(false);
    }
    void Start()
    {
        panel.SetActive(false);
    }

   
    void Update()
    {
        
    }
}
