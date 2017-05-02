using UnityEngine;
using System.Collections;

public class MyDestory : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.localPosition = new Vector3(0, 0.002f, 0);
        Destroy(gameObject, 3f);
	}
	
	
}
