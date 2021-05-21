using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFoll cameraFollow;
    public Transform playerTransform;
    public float score;

    private void Start()
    {
        cameraFollow.Setup(() => playerTransform.position);
        score = 0f;
    }
}