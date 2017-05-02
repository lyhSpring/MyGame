using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goldQuantity : MonoBehaviour {
    public Text aa; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
         aa.text="金币："+MyGold.Gold.quantity;
	}
}
