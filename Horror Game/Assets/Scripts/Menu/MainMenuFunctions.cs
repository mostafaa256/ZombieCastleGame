using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunctions : MonoBehaviour
{
    public GameObject FadeScreenOut;
    public GameObject LoadingText;
    public AudioSource ClickButton;
    public AudioSource MainMenuMusic;

    public void NewGameButton()
    {
        StartCoroutine(StartNewGame());
    }

    IEnumerator StartNewGame()
    {
        FadeScreenOut.SetActive(true);
        ClickButton.Play();
        yield return new WaitForSeconds(3);
        LoadingText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
