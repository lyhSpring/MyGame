using UnityEngine;
using System.Collections;

public class MyAlwaysSou : MonoBehaviour {

    public GameObject objPrefabInstantSource;//音乐预知物体 

    private GameObject musicInstant = null;//场景中是否有这个物体  

    // Use this for initialization  

    void Start()
    {

        musicInstant = GameObject.Find("Sou(Clone)");

        if (musicInstant == null)
        {

            musicInstant = (GameObject)Instantiate(objPrefabInstantSource);

        }

    }
}
