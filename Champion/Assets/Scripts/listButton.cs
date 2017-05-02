using UnityEngine;
using System.Collections;
using DG.Tweening;

public class listButton : MonoBehaviour {

    private  Tween tweener;
    private Transform listtween;

    public Transform centerPoint;
	// Use this for initialization
	void Start () {
        listtween = GameObject.Find("List").transform;
       
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    public void listAppear()
    {
        tweener = listtween.DOMove(centerPoint.position, 2);
        //StartCoroutine("Dow");
    }
    //IEnumerator Dow()
    //{
    //    yield return new WaitForSeconds(2);
    //    Time.timeScale = 0;
    //}
}
