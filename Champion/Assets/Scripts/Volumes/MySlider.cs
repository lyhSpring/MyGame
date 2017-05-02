using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MySlider : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
        GetComponent<Slider>().onValueChanged.AddListener(
            (float a) => { 
               GameObject.Find("Sou(Clone)").GetComponent<AudioSource>().volume = a;
            }
        );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
