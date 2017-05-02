using UnityEngine;
using System.Collections;
using DG.Tweening;

public class VolButton : MonoBehaviour {
    private Transform volume;
    private Tween tweener;
    public Transform centPoint;
	// Use this for initialization
	void Start () {
        volume = GameObject.Find("volume").transform;
        centPoint = GameObject.Find("kong").transform;
	}
	
	// Update is called once per frame
	public void volbut() {
        tweener = volume.DOMove(centPoint.position, 2);
       
	}
}
