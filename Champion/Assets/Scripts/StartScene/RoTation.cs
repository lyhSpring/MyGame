using UnityEngine;
using System.Collections;

public class RoTation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Rotate(0,0.3f,0);
	}
}
