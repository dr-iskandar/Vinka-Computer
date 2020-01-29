using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptPopUp : MonoBehaviour {

	public Canvas IniPOPUP;
	public bool tampil = false;

	
	// Update is called once per frame
	public void TampilPopUp() {
	if (tampil == false) {
			tampil = true;
		IniPOPUP.enabled = true;
	}else if (tampil =true) {
		tampil = false;
		IniPOPUP.enabled = false;
	}
		
	}
}