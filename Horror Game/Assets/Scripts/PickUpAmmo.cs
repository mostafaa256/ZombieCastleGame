using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{
    public GameObject TheAmmo;
    public GameObject AmmoPanelDisplay;
    public GameObject AmmoBoxLight;


    void OnTriggerEnter(Collider other)
    {
        AmmoPanelDisplay.SetActive(true);
        GlobalAmmo.AmmoCount += 7;
        TheAmmo.SetActive(false);
        AmmoBoxLight.SetActive(false);

    }
}
