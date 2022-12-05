using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinToMainMenu : MonoBehaviour
{
    public GameObject LoadingText;
    public AudioSource ClickButton;

    void Start()
    {
        UnlockMouse();
    }
    public void MainMenuButton()
    {
        StartCoroutine(MenuButton());
    }

    IEnumerator MenuButton()
    {
        ClickButton.Play();
        LoadingText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
