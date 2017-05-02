using UnityEngine;
using System.Collections;

public class MyAudios : MonoBehaviour
{
    public AudioClip a;//漂移音效
    public AudioSource b;//平时音效
    private float myTime = 0;
    bool f = false;
    private Wheel speed;
    private Rigidbody rb; //汽车的重心
    // Use this for initialization
    void Start()
    {
        speed = GameObject.FindWithTag("Player").GetComponent<Wheel>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z)&& speed.addSpeed >= 15)
        {
               AudioSource.PlayClipAtPoint(a, transform.position);
       
            
        }
        
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                b.Play();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                b.volume = 0.3f;
                f = true;
            }
            if (f)
            {
                myTime += Time.deltaTime;
            }
            if (myTime >= 3f)
            {
                b.volume = 0.1f;
                f = false;
                myTime = 0;
            }

        }

    }

