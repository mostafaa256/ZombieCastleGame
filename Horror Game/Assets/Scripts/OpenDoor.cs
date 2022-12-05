using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    public float TheDistance;
    public GameObject DisplayAction;
    public GameObject TextAction;
    public GameObject TheDoor;
    public AudioSource TheSound;

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
            }
        }
    }

    void OnMouseExit()
    {
        DisplayAction.SetActive(false);
        TextAction.SetActive(false);
    }
}
