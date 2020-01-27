using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public void GoTo1MainMenu(){
		Application.LoadLevel("MainMenu");
	}
	public void GoToMainMenubelajarorgan(){
		Application.LoadLevel("latihan");
	}
	public void GoToARCamera(){
		Application.LoadLevel("marker");
	}
	public void GoToloadingar(){
		Application.LoadLevel("Loadingar");
	}

	public void GoToloadingawal(){
		Application.LoadLevel("Loading");
	}
	//DIBAWAH INI SKRIP BUKA SOAL KUIZ//
	public void GoToKUIZSATU(){
		Application.LoadLevel("Kuiz1");
	}
	public void GoToKUIZDUA(){
		Application.LoadLevel("Kuiz2");
	}
	public void GoToKUIZTIGA(){
		Application.LoadLevel("Kuiz3");
	}
	public void GoToKUIZEMPAT(){
		Application.LoadLevel("Kuiz4");
	}
	public void GoToKUIZLIMA(){
		Application.LoadLevel("Kuiz5");
	}

	public void GoToKUIZMENANG(){
		Application.LoadLevel("Hasil Kuiz");
	}
	//DIBAWAH INI SKRIP HASIL SCORE//

	public void GoToL1(){
		Application.LoadLevel("LAPTOP1");
	}
	public void GoToL2(){
		Application.LoadLevel("LAPTOP2");
	}
	public void GoToL3(){
		Application.LoadLevel("LAPTOP3");
	}
	public void GoToL4(){
		Application.LoadLevel("LAPTOP4");
	}

	public void ExitApplication(){
		Application.Quit ();
	}

}
