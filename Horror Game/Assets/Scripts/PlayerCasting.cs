using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    
    public static float DistanceFromTheTarget;
	public float DisToTarget;

	void Update () {
		RaycastHit Hit;
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Hit)) {
			DisToTarget = Hit.distance;
			DistanceFromTheTarget = DisToTarget;
		}
		
	}
}
