using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    public float EnemySpeed = 0.03f;
    public bool AttackTrigger = false;
    public bool isAttacking = false;
    public AudioSource PainSound01;
    public GameObject ThePainFlash;

    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (AttackTrigger == false)
        {
            EnemySpeed = 0.03f;
            TheEnemy.GetComponent<Animator>().Play("Zombie Running");
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        }
        if (AttackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0;
            TheEnemy.GetComponent<Animator>().Play("Zombie Attack");
            StartCoroutine(InflictDamage());
        }

    }

    void OnTriggerEnter()
    {
        AttackTrigger = true;
    }

    void OnTriggerExit()
    {
        AttackTrigger = false;
    }


    IEnumerator InflictDamage()
    {

        isAttacking = true;
        yield return new WaitForSeconds(1.3f);
        ThePainFlash.SetActive(true);
        PainSound01.Play();
        GlobalHealth.currentHealth -= 25;
        yield return new WaitForSeconds(1);
        ThePainFlash.SetActive(false);
        yield return new WaitForSeconds(2);
        isAttacking = false;
    }
}
