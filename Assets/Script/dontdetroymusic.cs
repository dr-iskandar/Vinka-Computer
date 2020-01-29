using System.Collections;
using UnityEngine;

public class dontdetroymusic : MonoBehaviour {

void awake()
	{
		GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
		if(objs.Length > 1)
			Destroy (this.gameObject);
		
		DontDestroyOnLoad (this.gameObject);
		
	}

}
