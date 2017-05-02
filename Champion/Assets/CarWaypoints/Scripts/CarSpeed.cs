using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class CarSpeed : MonoBehaviour {
    private  Wheel a;
    
	// Use this for initialization
	void Start () {
        a = GameObject.FindWithTag("Player").GetComponent<Wheel>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<Text>().text = "当前速度" + a.addSpeed.ToString();
	}
}
