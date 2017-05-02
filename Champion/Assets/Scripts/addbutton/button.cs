using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    private GameObject obj;
    // Use this for initialization
    void Start()
    {
        obj = GameObject.Find("Camera");
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void myZoomx()
    {
        obj.GetComponent<Camera>().fieldOfView -= 2;
    }
}
