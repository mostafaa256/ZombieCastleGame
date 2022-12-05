using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTrigger : MonoBehaviour
{
    public AudioSource DoorSound;
    public AudioSource MusicAfterOpenDoor;
    public GameObject TheZombie;
    public GameObject TheDoor;
    public AudioSource GamePlayMusic;
    public GameObject ThirdTrigger;



    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("Open second door anim");
        DoorSound.Play();
        TheZombie.SetActive(true);
        ThirdTrigger.SetActive(true);
        StartCoroutine(PlayMusicAfterOpenDoor());
    }

    IEnumerator PlayMusicAfterOpenDoor()
    {
        yield return new WaitForSeconds(0.4f);
        GamePlayMusic.Stop();
        MusicAfterOpenDoor.Play();

    }

}
