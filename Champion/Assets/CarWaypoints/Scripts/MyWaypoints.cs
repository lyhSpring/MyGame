using UnityEngine;
using System.Collections;

public class MyWaypoints : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;  //代理对象
    public Transform[] pois;   //目标点数组
    private int i = 0;         //数组索引
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 6)
        {
            i = 0;
        }
        if (agent.remainingDistance == 0)
        {
            agent.destination = pois[i].position;
            i++;
            i %= 7;
        }


    }


}
