using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverControl : MonoBehaviour
{
    public GameObject LoadingText;
    public AudioSource ClickButton;

    void Start()
    {
        UnlockMouse();
    }
    public void RestartButton()
    {
        StartCoroutine(RestartFunButton());
    }

    IEnumerator RestartFunButton()
    {
        ClickButton.Play();
        LoadingText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ExitButton()
    {
        Application.Quit();
    }


}
