using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyToggle : MonoBehaviour {
    private AudioSource _aud;
	// Use this for initialization
	void Start () {
        _aud = GameObject.Find("Sou(Clone)").GetComponent<AudioSource>();
        GetComponent<Toggle>().onValueChanged.AddListener(
            (bool a) => {
                _aud.enabled = !a;
            }
         );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
