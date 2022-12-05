using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GlobalHealth : MonoBehaviour
{
    public static int currentHealth = 100;
    public int internalHealth;
    public GameObject DisplayHealth;

    void Update()
    {
        internalHealth = currentHealth;
        DisplayHealth.GetComponent<Text>().text = "" + currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(5);
            currentHealth = 100;
            GlobalAmmo.AmmoCount=0;
        }
    }
}
