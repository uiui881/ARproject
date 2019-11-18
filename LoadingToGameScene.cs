using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingToGameScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(changeToGameScene());
    }

    IEnumerator changeToGameScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("IntroScene");
    }
}
