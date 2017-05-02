using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class VolumeButton : MonoBehaviour {
    private Transform volume;
    private Tween tweener;
    public Transform centerPoint;
	// Use this for initialization
	void Start () {
        volume = GameObject.Find("volume").transform;
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void listApp()
    {
        tweener = volume .DOMove(centerPoint.position, 2);

        transform.parent.DOMove(new Vector3(2000, 200, 0),2);

        //StartCoroutine("Dow3");
    }

    //IEnumerator Dow3()
    //{
    //    Time.timeScale = 1;
    //    yield return 0;
    //}

}
