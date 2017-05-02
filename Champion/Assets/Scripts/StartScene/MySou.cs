using UnityEngine;
using System.Collections;

public class MySou : MonoBehaviour {
    

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
