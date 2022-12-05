using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroToScene01 : MonoBehaviour
{
    public GameObject FadeScreenOut;
    void Start()
    {
        StartCoroutine(TakeToScene01());
    }
    IEnumerator TakeToScene01()
    {
        yield return new WaitForSeconds(53);
        FadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

}
