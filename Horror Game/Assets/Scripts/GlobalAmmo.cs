using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int AmmoCount;
    public GameObject DisplayAmmo;
    public int InternalAmmo;

    void Update()
    {
        InternalAmmo = AmmoCount;
        DisplayAmmo.GetComponent<Text>().text = "" + AmmoCount;
    }
}
