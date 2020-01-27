using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loading : MonoBehaviour {

public Transform LoadingReload;

[SerializeField] private float currentAmount;
[SerializeField] private float speed;

void Update () {
	if (currentAmount < 100) {
		currentAmount += speed * Time.deltaTime;
		Debug.Log ((int)currentAmount);
	} else {
			Application.LoadLevel ("MainMenu");
	}

	LoadingReload.GetComponent<Image> ().fillAmount = currentAmount / 100;
 }
}
