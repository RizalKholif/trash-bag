using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TrashDestroy : MonoBehaviour {
	public GameObject enemy;

	void Start(){
	
	}

	void Update(){
	
	}
	void OnTriggerEnter(Collider other)
	{
		switch(other.gameObject.tag)
		{
		case "TongSampah":
			Destroy (this.gameObject);
			Debug.Log ("Masuk");
			break;
		case "Plan":
			Destroy (this.gameObject);
			Debug.Log ("Tidak Masuk");
			break;
		}

	}


}
