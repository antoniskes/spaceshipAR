using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler {
	public GameObject vbButtonObject;
	public GameObject ship;
	// Use this for initialization
	void Start () {
		vbButtonObject = GameObject.Find("virtualButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);		
	}
	public void OnButtonPressed (VirtualButtonBehaviour vb){	
		ship = GameObject.Find("Tachi_LP");
		ship.GetComponent<SpinShip>().enabled = true;
	}
	public void OnButtonReleased (VirtualButtonBehaviour vb){
		ship = GameObject.Find("Tachi_LP");
		ship.GetComponent<SpinShip>().enabled = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
