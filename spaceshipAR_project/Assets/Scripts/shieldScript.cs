using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class shieldScript : MonoBehaviour {	
	public GameObject ship;
	public GameObject shield;
	public void changeShieldState(){
			ship = GameObject.Find("Tachi_LP");
			shield = ship.transform.GetChild(0).gameObject;
			if (shield.activeSelf == true){
				shield.SetActive(false);
			}
			else{
				shield.SetActive(true);
			}
		
	}

}
