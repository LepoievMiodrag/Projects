using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points2 : MonoBehaviour
{
    public float score;

    void Start()
    {
        score += 4000f;
    }

    public void AddScore()
    {
        score += 75f;
    }
}
