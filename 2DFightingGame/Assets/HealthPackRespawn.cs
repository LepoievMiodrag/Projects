using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackRespawn : MonoBehaviour
{
    public GameObject Healthpack1;

    public GameObject Healthpack2;

    public GameObject Healthpack3;

    public GameObject Healthpack4;

    public GameObject Healthpack5;

    public GameObject Healthpack6;

    public GameObject Healthpack7;

    public GameObject Healthpack8;

    public GameObject Healthpack9;

    public GameObject Healthpack10;

    public GameObject Healthpack11;

    public HealthCounter hpcount;

    public void Resp()
    {
        if (hpcount.count == 0)
        {
            Invoke("HpResp", 15f);
        }
    }

    void HpResp()
    {
        Healthpack1.SetActive(true);
        Healthpack2.SetActive(true);
        Healthpack3.SetActive(true);
        Healthpack4.SetActive(true);
        Healthpack5.SetActive(true);
        Healthpack6.SetActive(true);
        Healthpack7.SetActive(true);
        Healthpack8.SetActive(true);
        Healthpack9.SetActive(true);
        Healthpack10.SetActive(true);
        Healthpack11.SetActive(true);

        hpcount.count = 11;
    }
}
