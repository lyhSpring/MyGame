using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button1 : MonoBehaviour {
    private GameObject obj;
    // Use this for initialization
    void Start()
    {
       obj = GameObject.Find("Camera");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void myZoomy()
    {
        obj.GetComponent<Camera>().fieldOfView += 2;
    }
}
