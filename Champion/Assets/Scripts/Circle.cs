using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if ( GameManager.Gm.curSelectCar==0)
        {
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
        }
        if (GameManager.Gm.curSelectCar == 1)
        {
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
        }
        if (GameManager.Gm.curSelectCar == 2)
        {
            car1.SetActive(false);
            car2.SetActive(true);
            car3.SetActive(false);
        }
        if (GameManager.Gm.curSelectCar == 3)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(true);
        }
        

	}
}
