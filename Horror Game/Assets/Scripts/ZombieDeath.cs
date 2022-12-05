using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int ZombieHealth = 20;
    public GameObject TheEnemy;
    public int StatusChecker;
    public AudioSource MusicAfterOpenDoor;
    public AudioSource GamePlayMusic;

    void DamageZombie(int DamageAmount)
    {
        ZombieHealth -= DamageAmount;
    }




    void Update()
    {
        if (ZombieHealth <= 0 && StatusChecker == 0)
        {
            this.GetComponent<Rigidbody>().useGravity = false;
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusChecker = 2;
            TheEnemy.GetComponent<Animator>().Play("FallingBack");
            GamePlayMusic.Play();
            MusicAfterOpenDoor.Stop();
        }
    }
}
