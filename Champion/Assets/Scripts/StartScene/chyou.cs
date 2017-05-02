using UnityEngine;
using System.Collections;
using DG.Tweening;

public class chyou : MonoBehaviour
{
    private Transform che;
    private Tween tweener2;

    public Transform kong;

    // Use this for initialization
    void Start()
    {
        che = GameObject.Find("ch2").transform;
    }

    // Update is called once per frame
    public void You()
    {
        GameManager.Gm.curSelectType = 1;
        tweener2 = che.DOMove(kong.position, 1);

    }
}
