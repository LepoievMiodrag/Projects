﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float score = 0f;
    
    public void AddScore()
    {
        score += 75f;
    }
}
