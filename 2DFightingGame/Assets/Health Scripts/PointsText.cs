using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsText : MonoBehaviour
{
    public Points pt;
    public Text ptxt;

    void Update()
    {
        ptxt = GetComponent<Text>();
        ptxt.text = pt.score.ToString();
    }
}
