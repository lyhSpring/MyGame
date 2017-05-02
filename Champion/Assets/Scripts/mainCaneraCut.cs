using UnityEngine;
using System.Collections;

public class mainCaneraCut : MonoBehaviour {
    public Camera aaa;
    public Camera bbb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            aaa.GetComponent<Camera>().depth = -5;
            bbb.GetComponent<Camera>().depth = -5;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            aaa.GetComponent<Camera>().depth = -1;
            bbb.GetComponent<Camera>().depth = -5;
        }
	}
}
