using UnityEngine;
using System.Collections;

public class Wheel : MonoBehaviour
{
    public WheelCollider bl;//后左轮
    public WheelCollider br;//后右轮
    public WheelCollider l;//前左轮
    public WheelCollider r;//前右轮
    public float Maxl=500f;//力矩
    public float Maxz=20f;//角速度
    private  float maxBrakeTorque = 10f;//手刹参数
    
    public Transform bll;//后左轮的transform
    public Transform brr;//后右轮的transform
    public Transform ll;//前左轮的transform
    public Transform rr;//前右轮的transform
    
    private Vector3 com;//重心的位置
    private  Rigidbody rb; //汽车的重心


    public float slipForowStiff = 5f;
    public float slipSteerStiff = 0.8f;//漂移时向前和曲线摩擦力

    public float initForwaedStiff =5;//平时向前和曲线摩擦力
    public float initSteerStiff=8;


    private float qz = 0f;//前轮的转向
    private float qy = 0f;

    private Vector3 speed;
    public float addSpeed;//给汽车刚体加力
    public float mySpeed;


   // public bool isPlay=false;
    void Start()
    {
        addSpeed = 0;
        //使刚体的重心下降
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
        com.y -= 0.5f; 
        rb.centerOfMass = com;

        addSpeed = Mathf.Lerp(20, 30, 0.4f);
        mySpeed = Mathf.Lerp(0, 20, 0.4f);
       
    }

    void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        bl.motorTorque = Maxl * ver;
        br.motorTorque = Maxl * ver;
       
        l.steerAngle = Maxz * hor;
        r.steerAngle = Maxz * hor;

        
    }

   
    void Update()
    {
        //Debug.Log(Maxl);
        qz += bl.rpm * 360 * Time.deltaTime / 60;//rpm  每分钟的转数
        qz = Mathf.Repeat(qz, 360);
        qlxz(ll, qz,l.steerAngle);

        qy += bl.rpm * 360 * Time.deltaTime / 60;//rpm  每分钟的转数
        qy = Mathf.Repeat(qy, 360);
        qlxz(rr, qy,r.steerAngle);


        bll.Rotate(bl.rpm * 360 * Time.deltaTime / 60, 0, 0);//控制转向
        brr.Rotate(bl.rpm * 360 * Time.deltaTime / 60, 0, 0);
        

        
        if (Input.GetKey(KeyCode.Z))
        {

          //  isPlay = true;
            l.brakeTorque = maxBrakeTorque;
            r.brakeTorque = maxBrakeTorque;//前轮刹车
            bl.motorTorque = 0;
            br.motorTorque = 0;//扭矩
            rb.drag = 0.5f;
            addSpeed = Mathf.Lerp(addSpeed, 15, 5f * Time.deltaTime);
            SetWheelFrictionStiff(bl, slipForowStiff, slipSteerStiff);
            SetWheelFrictionStiff(br, slipForowStiff, slipSteerStiff);
            
        }
        else
        {
           // isPlay = false;
            l.brakeTorque = 0;
            r.brakeTorque = 0;
           rb.drag = 0f;

            SetWheelFrictionStiff(bl, initForwaedStiff, initSteerStiff);
            SetWheelFrictionStiff(br, initForwaedStiff, initSteerStiff);
        }






        if (Input.GetKeyDown(KeyCode.LeftControl)&&addSpeed<=30f)
        {
            
                addSpeed = 30f;

            rb.velocity = gameObject.transform.forward * addSpeed;
        }
        if (Input.GetKey(KeyCode.LeftControl)&&addSpeed>30f)
        {
            float temp = addSpeed;
            addSpeed = Mathf.Lerp(temp, 30f, 5f*Time.deltaTime);
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            addSpeed += 5;
            rb.velocity =gameObject.transform.forward * addSpeed;
        }
       
    }
    //改变车轮的向前摩擦力和转弯摩擦力
    private void SetWheelFrictionStiff(WheelCollider bl, float slipForowStiff, float slipSteerStiff)
    {
        WheelFrictionCurve temp = bl.forwardFriction;
        temp.stiffness = slipForowStiff;
        bl.forwardFriction = temp;

        temp = bl.sidewaysFriction;
        temp.stiffness = slipSteerStiff;
        bl.sidewaysFriction = temp;
    }

    
    void qlxz(Transform a, float engle,float engley)
    {
        Vector3 ea = new Vector3(engle, engley, 0);
        a.localRotation = Quaternion.Euler(ea);
    }
    
}
