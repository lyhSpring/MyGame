using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MyBool : MonoBehaviour {
    public Transform volume1;
    public Transform volume2;
    private Tween tweener;
    public Transform centerPoint;
    private bool aa=true;
    private bool bb = true;

    private int zong;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && bb == true)
        {
            tweener = volume1.DOMove(centerPoint.position, 2);
            MyGold.Gold.quantity += 100;
            aa = false;
        }
        if (other.tag=="Enemy"&&aa==true)
        {
            tweener = volume2.DOMove(centerPoint.position, 2);
            MyGold.Gold.quantity += 10;
            bb = false;
        }
    }


}
