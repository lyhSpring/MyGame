using UnityEngine;
using System.Collections;

public class cjntiao : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Strplay()
    {
        GameManager.Gm.curSelectType = 0;
        Application.LoadLevelAsync("xuanche");
        //StartCoroutine("Dow3");
    }
    //IEnumerator Dow3()
    //{
    //    Time.timeScale = 1;
    //    yield return 0;
    //}
}
