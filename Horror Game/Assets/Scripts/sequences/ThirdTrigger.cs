using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTrigger : MonoBehaviour
{

    public AudioSource MusicForZombiesFight;
    public GameObject TheZombie1;
    public GameObject TheZombie2;
    public GameObject TheZombie3;
    public GameObject TheZombie4;
    public GameObject TheZombie5;
    public AudioSource GamePlayMusic;



    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheZombie1.SetActive(true);
        TheZombie2.SetActive(true);
        TheZombie3.SetActive(true);
        TheZombie4.SetActive(true);
        TheZombie5.SetActive(true);
        StartCoroutine(PlayMusicForZombiesFight());
    }

    IEnumerator PlayMusicForZombiesFight()
    {
        yield return new WaitForSeconds(0.4f);
        GamePlayMusic.Stop();
        MusicForZombiesFight.Play();

    }

}
