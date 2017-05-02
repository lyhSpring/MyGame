using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
    public   GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    private GameObject Qbut;
    public  GameObject pur1;
    public GameObject pur2;

    
	// Use this for initialization
	void Start () {
        Qbut = GameObject.Find("QButton");
       
	}
	
	// Update is called once per frame
    public  void Car1b()
    {
        Qbut.SetActive(true);
        pur1.SetActive(false);
        pur2.SetActive(false);
        car1.SetActive(true);
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(false);
       
        GameManager.Gm.curSelectCar = 1;
       
	}
    public void Car2b()
    {
        car1.SetActive(false);
        car2.SetActive(true);
        car3.SetActive(false);
        car4.SetActive(false);
        if (GameManager.Gm.que)
        {
        Qbut.SetActive(false);
        pur1.SetActive(true);
        pur2.SetActive(false);
        
        }
        else
        {
            Qbut.SetActive(true);
            pur1.SetActive(false);
            pur2.SetActive(false);
        }
        GameManager.Gm.curSelectCar = 2;
       
    }
    public void Car3b()
    {
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(true);
        car4.SetActive(false);
        if (GameManager.Gm.que2)
        {
        Qbut.SetActive(false);
        pur1.SetActive(false);
        pur2.SetActive(true);

        }
        else
        {
            Qbut.SetActive(true);
            pur1.SetActive(false);
            pur2.SetActive(false);
        }
       
        GameManager.Gm.curSelectCar = 3;
        
    }
    public void Car4b()
    {
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(false);
        car4.SetActive(true);
        Qbut.SetActive(false);
        pur1.SetActive(false);
        pur2.SetActive(false);
    }
}
