using UnityEngine;
using System.Collections;
using DG.Tweening;

public class VXButton : MonoBehaviour {
    private Tween tweener;
    private Transform volume;
    // Use this for initialization
    void Start()
    {
        volume = GameObject.Find("volume").transform;
    }
    public void litA()
    {
        tweener = volume.DOMove(new Vector3(384,1000, 0), 2);
    }
}
