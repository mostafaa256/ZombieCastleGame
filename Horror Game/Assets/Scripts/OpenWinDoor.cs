using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenWinDoor : MonoBehaviour
{
    public float TheDistance;
    public GameObject DisplayAction;
    public GameObject TextAction;
    public GameObject TheDoor;
    public AudioSource TheSound;
    public GameObject LoadingText;
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTheTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextAction.GetComponent<Text>().text = "Open The Door";
            DisplayAction.SetActive(true);
            TextAction.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                DisplayAction.SetActive(false);
                TextAction.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("open door anim1");
                TheSound.Play();
                StartCoroutine(EndGameToWinScene());
            }
        }
    }

    void OnMouseExit()
    {
        DisplayAction.SetActive(false);
        TextAction.SetActive(false);
    }

    IEnumerator EndGameToWinScene()
    {

        LoadingText.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }
}
