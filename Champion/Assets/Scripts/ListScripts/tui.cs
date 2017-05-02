using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class tui : MonoBehaviour {
    public  Transform listbut;
    private Tween tweener;
	// Use this for initialization
	public  void Sta () {
        
                tweener = listbut.DOMove(new Vector3(2000, 212, 0), 2);
                //StartCoroutine("Dow2");
     
	}


    //IEnumerator Dow2()
    //{
    //    Time.timeScale = 1;
    //    yield return 0;
    //}
	// Update is called once per frame
	void Update () {
	
	}
    //public void abc()
    //{
    //    tweener = listbut.DOMove(new Vector3(2000, 212, 0), 2);

    //}
   
}
