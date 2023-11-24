using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;

    [Range(0.0f, 1.0f)]
    public float Percent;
    
    void FixedUpdate() {
        float xValue = Mathf.Lerp(this.transform.position.x, Target.position.x, Percent);
        this.transform.position = new Vector3(xValue, Target.position.y + Offset.y, Target.position.z + Offset.z);
    }
}
