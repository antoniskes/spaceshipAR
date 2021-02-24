using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class bigger : MonoBehaviour {

	public void upscale(){
		// Scale the object by 0.3(x axis and z axis)
        this.transform.localScale += new Vector3(0.3F, 0.006F, 0.3F);
	}
}
