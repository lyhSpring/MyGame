using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyTime : MonoBehaviour {
     
    private Text time_text;
    private float _time=5;
    private bool isTime=true;

    public Wheel scene;
    public Wheel scene2;
    public Wheel scene3;
	// Use this for initialization
	void Start () {
        time_text = GetComponent<Text>();


        
	}
	
	// Update is called once per frame
	void Update () {
        if (isTime)
        {
            _time -= Time.deltaTime;
            time_text.text = _time.ToString("0");
            if (_time<=0)
            {
                isTime = false;
                time_text.text = "";

                scene.enabled = true;
                scene2.enabled = true;
                scene3.enabled = true;

                GameObject.Find("RoamCamera").GetComponent<Camera>().depth = -3;
            }
        }
	}
}
