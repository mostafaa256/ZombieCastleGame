using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAnimations : MonoBehaviour
{
    public int FireLightMode;
	public GameObject FireLight;


	void Update () {
		if (FireLightMode == 0) {
			StartCoroutine (AnimateLight ());
		}
		
	}

	IEnumerator AnimateLight () {
		FireLightMode = Random.Range (1, 4);
		if (FireLightMode == 1) {
			FireLight.GetComponent<Animation> ().Play ("Fire Animation1");
		}
		if (FireLightMode == 2) {
			FireLight.GetComponent<Animation> ().Play ("Fire Animation2");
		}
		if (FireLightMode == 3) {
			FireLight.GetComponent<Animation> ().Play ("Fire Animation3");
		}
		yield return new WaitForSeconds (0.99f);
		FireLightMode = 0;

    
	}
}
