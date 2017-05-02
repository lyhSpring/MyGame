using UnityEngine;
using System.Collections;

public class SmoothFollowA : MonoBehaviour {

    public Transform target;
    public float distance = 10f;
    public float height = 5f;
    public float heightDamping = 2f;
    public float rotationDamping = 3f;

    void LateUpdate()
    {
        // 计算当前的旋转角度
        float wantedRotationAngle = target.eulerAngles.y;
        float wantedHeight = target.position.y + height;

        float currentRotationAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        // 阻尼绕y轴的旋转角度
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

        // Damp the height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // 转换成旋转角度
        Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        // 设置相机在XZ平面的位置：
        // 距离米远的目标
        transform.position = target.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        // 设置相机的高度
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        // 总是看目标
        transform.LookAt(target);
    }
}
