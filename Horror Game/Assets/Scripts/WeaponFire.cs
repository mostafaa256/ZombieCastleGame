using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponFire : MonoBehaviour
{
    public GameObject TheWeapon;
    public GameObject MuzzleFlash;
    public AudioSource WeaponFireSound;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GlobalAmmo.AmmoCount >= 1)
        {
            if (IsFiring == false)
            {
                GlobalAmmo.AmmoCount -= 1;
                StartCoroutine(FireingWeapon());
            }
        }

    }

    IEnumerator FireingWeapon()
    {
        RaycastHit shot;
        IsFiring = true;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            TargetDistance = shot.distance;
            shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        TheWeapon.GetComponent<Animation>().Play("Weapon anim");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("Weapon fire anim");
        WeaponFireSound.Play();
        yield return new WaitForSeconds(0.5f);
        IsFiring = false;
    }
}
