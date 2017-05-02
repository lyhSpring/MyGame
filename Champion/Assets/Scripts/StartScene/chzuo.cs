                                                                                                   using UnityEngine;
using System.Collections;
using DG.Tweening;

public class chzuo : MonoBehaviour {
    private Transform ch2;
    private Tween tweener;

    public Transform ch1;

	// Use this for initialization
	void Start () {
        ch2 = GameObject.Find("ch2").transform;
	}
	
	// Update is called once per frame
	public void Zuo () {
        GameManager.Gm.curSelectType = 2;
        tweener = ch2.DOMove(ch1.position,1);
	}
}
