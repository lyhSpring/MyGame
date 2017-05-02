using UnityEngine;
using System.Collections;
using DG.Tweening;

public class chaButton : MonoBehaviour {
    private Tween tweener;
    private Transform volume;
	// Use this for initialization
    void Start()
    {
        volume = GameObject.Find("volume").transform;
    }
    public void listA()
    { 
        tweener = volume.DOMove(new Vector3(200, 800, 0), 2);
    }
}
