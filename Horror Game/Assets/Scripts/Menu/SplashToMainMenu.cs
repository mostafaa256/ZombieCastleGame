using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMainMenu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(TakeToMainMenu());
    }
    IEnumerator TakeToMainMenu()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(1);
    }

}
