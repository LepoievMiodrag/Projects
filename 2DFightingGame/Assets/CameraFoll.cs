using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFoll : MonoBehaviour
{
    private Func<Vector3> GetCameraFollowPositionFunc;

   public void Setup(Func<Vector3> GetCameraFollowPositionFunc)
    {
        this.GetCameraFollowPositionFunc = GetCameraFollowPositionFunc;
    }

    void Update()
    {
        Vector3 cameraFollowPosition = GetCameraFollowPositionFunc();
        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}