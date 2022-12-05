using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAidKit : MonoBehaviour
{
    public GameObject TheAidKit;
    //public GameObject HealthPanelDisplay;
    public GameObject AidKitBoxLight;


    void OnTriggerEnter(Collider other)
    {

        if (GlobalHealth.currentHealth < 100)
        {
            GlobalHealth.currentHealth += 25;
            TheAidKit.SetActive(false);
            AidKitBoxLight.SetActive(false);
        }


    }
}
