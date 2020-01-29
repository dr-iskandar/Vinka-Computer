using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loadingar : MonoBehaviour {

public Transform LoadingReload;

[SerializeField] private float currentAmount;
[SerializeField] private float speed;

void Update () {
	if (currentAmount < 100) {
		currentAmount += speed * Time.deltaTime;
		Debug.Log ((int)currentAmount);
	} else {
			Application.LoadLevel ("marker");
	}

	LoadingReload.GetComponent<Image> ().fillAmount = currentAmount / 100;
 }
}
