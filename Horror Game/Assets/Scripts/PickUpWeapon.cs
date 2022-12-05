using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWeapon : MonoBehaviour
{
    public float TheDistance;
	public GameObject DisplayAction;
	public GameObject TextAction;
	public GameObject FakeWeapon;
	public GameObject RealWeapon;
	public GameObject TheArrow;
	public GameObject TheSecondTrigger;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTheTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 2) {
			TextAction.GetComponent<Text>().text = "Pick Up The Weapon!";
			DisplayAction.SetActive (true);
			TextAction.SetActive (true);
		}
		if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				DisplayAction.SetActive(false);
				TextAction.SetActive(false);
				FakeWeapon.SetActive (false);
				RealWeapon.SetActive (true);
				TheArrow.SetActive (false);
				TheSecondTrigger.SetActive(true);
				
			}
		}
	}

	void OnMouseExit() {
		DisplayAction.SetActive (false);
		TextAction.SetActive (false);
	}
}
