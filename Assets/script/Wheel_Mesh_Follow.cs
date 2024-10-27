using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel_Mesh_Follow : MonoBehaviour
{
    [Header("Wheel Meshes")]
    public Transform wm_FrontLeft;
    public Transform wm_FrontRight;
    public Transform wm_BackLeft;
    public Transform wm_BackRight;

    [Header("Wheel Colliders")]
    public WheelCollider wc_FrontLeft;
    public WheelCollider wc_FrontRight;
    public WheelCollider wc_BackLeft;
    public WheelCollider wc_BackRight;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        UpdateWheelOrientation(wc_FrontLeft, wm_FrontLeft);
        UpdateWheelOrientation(wc_FrontRight, wm_FrontRight);
        UpdateWheelOrientation(wc_BackRight, wm_BackRight);
        UpdateWheelOrientation(wc_BackLeft, wm_BackLeft);

    }

    void UpdateWheelOrientation(WheelCollider wc, Transform wm)
    {
        Vector3 templocation;
        Quaternion tempRotation;

        wc.GetWorldPose(out templocation, out tempRotation);

        wm.position = templocation;
        wm.rotation = tempRotation;
    }
}
