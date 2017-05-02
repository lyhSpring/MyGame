using UnityEngine;
using System.Collections;

public class MyMark : MonoBehaviour {

    public Material skidMarkMat;//轮胎印材质球
    public float skidMarkWidth = 0.25f;//轮胎印宽度
    public float minSkidThrehold = 20f;//多大滑动摩擦力才开始画痕迹
    private WheelCollider wc;//车轮碰撞器

    private bool isSkidding=false;//上一帧是否有划痕

    private bool isHaveLastVertices = false;//是否有顶点
    private Vector3[] lastVertices=new Vector3[2];//轮胎与地面接触点的位置
    private Vector3 lastHitPos;//上一帧划痕位置

    void Start()
    {
        wc = GetComponent<WheelCollider>();
    }
	
	void Update () {
        WheelHit hit; //轮胎与地面接触点
        if (wc.GetGroundHit(out hit))
        {
            
            Vector3 nor = hit.normal;//法线
            Vector3 pos = hit.point;//接触点的位置
           // float fraction =Mathf.Abs(hit.forwardSlip);//前滑摩擦力
           
            if (Input.GetKey(KeyCode.Z))
            {
                if (isSkidding)//上一帧有划痕
                {
                    drawSkidMark(lastHitPos, pos, nor);//画刹车痕
                }
                else
                {
                    lastHitPos = pos;//如果上一帧没有就把这一帧位置记录下来
                }
                isSkidding = true;
            }
            else
            {
               //lastHitPos=new Vector3 (0,0,0);
                
                isSkidding = false;
                isHaveLastVertices = false;
            }
        }

	}

    private void drawSkidMark(Vector3 lastHitPos, Vector3 pos, Vector3 nor)//画刹车印
    {
       
        Vector3 zDir = (pos - lastHitPos).normalized;//z轴方向
      
        Vector3 xDir = Vector3.Cross(nor, zDir).normalized;//x轴方向
        if (isHaveLastVertices)
        {
            Vector3[] vertices = new Vector3[4];//声明四个顶点
            vertices[0] = lastVertices[0];
            vertices[1] = lastVertices[1];
            

            vertices[2] = pos - skidMarkWidth * xDir;
            vertices[3] = pos + skidMarkWidth * xDir;

            lastVertices[0] = vertices[3];
            lastVertices[1] = vertices[2];//当前帧的一二个顶点为上一帧的三四顶点

            int[] triangles = new int[] { 0, 1, 2, 0, 2, 3 };
            Vector2[] uvm = new Vector2[4];
            uvm[0] = new Vector2(0, 0);
            uvm[1] = new Vector2(1, 0);
            uvm[2] = new Vector2(1, 1);
            uvm[3] = new Vector2(0, 1);//创建三角形

            GameObject mark = new GameObject("Mark");//创建刹车印
            
            mark.AddComponent<MyDestory>();//添加销毁脚本
            MeshFilter filter = mark.AddComponent<MeshFilter>();//网格过滤器
            MeshRenderer meshRender = mark.AddComponent<MeshRenderer>();//添加网格渲染器
            Mesh mesh = new Mesh();//创建网格
            mesh.vertices = vertices;//刹车痕迹的四个顶点
            mesh.triangles = triangles;//三角形
           
            mesh.uv = uvm;//网格的基础纹理坐标
            mesh.RecalculateNormals();//重新计算网格的法线
            filter.mesh = mesh;//返回赋予网格过滤器的实例化的Mesh

            meshRender.material = skidMarkMat;//材质
            
        }
        else
        {
            lastVertices[1] = pos - skidMarkWidth * xDir;
            lastVertices[0] = pos + skidMarkWidth * xDir;//给一二顶点赋初始值
        }                                  
        isHaveLastVertices = true;//上一帧有划痕
    }
}
