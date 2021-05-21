using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject Enemy1;
    public EnemyHealth hp1;

    public GameObject Enemy2;
    public EnemyHealth hp2;

    public GameObject Enemy3;
    public EnemyHealth hp3;

    public GameObject Enemy4;
    public EnemyHealth hp4;

    public GameObject Enemy5;
    public EnemyHealth hp5;

    public GameObject Enemy6;
    public EnemyHealth hp6;

    public GameObject Enemy7;
    public EnemyHealth hp7;

    public GameObject Enemy8;
    public EnemyHealth hp8;

    public GameObject Enemy9;
    public EnemyHealth hp9;

    public GameObject Enemy10;
    public EnemyHealth hp10;

    public GameObject Enemy11;
    public EnemyHealth hp11;

    public GameObject Enemy12;
    public EnemyHealth hp12;

    public GameObject Enemy13;
    public EnemyHealth hp13;

    public GameObject Enemy14;
    public EnemyHealth hp14;

    public GameObject Enemy15;
    public EnemyHealth hp15;

    public GameObject Enemy16;
    public EnemyHealth hp16;

    public GameObject Enemy17;
    public EnemyHealth hp17;

    public GameObject Enemy18;
    public EnemyHealth hp18;

    public GameObject Enemy19;
    public EnemyHealth hp19;

    public GameObject Enemy20;
    public EnemyHealth hp20;

    public GameObject Enemy21;
    public EnemyHealth hp21;

    public GameObject Enemy22;
    public EnemyHealth hp22;

    public GameObject Enemy23;
    public EnemyHealth hp23;

    public GameObject Enemy24;
    public EnemyHealth hp24;

    public GameObject Enemy25;
    public EnemyHealth hp25;

    public GameObject Enemy26;
    public EnemyHealth hp26;

    public GameObject Enemy27;
    public EnemyHealth hp27;

    public GameObject Enemy28;
    public EnemyHealth hp28;

    public GameObject Enemy29;
    public EnemyHealth hp29;

    public GameObject Enemy30;
    public EnemyHealth hp30;

    public GameObject Enemy31;
    public EnemyHealth hp31;

    public GameObject Enemy32;
    public EnemyHealth hp32;

    public GameObject Enemy33;
    public EnemyHealth hp33;

    public GameObject Enemy34;
    public EnemyHealth hp34;

    public GameObject Enemy35;
    public EnemyHealth hp35;

    public GameObject Enemy36;
    public EnemyHealth hp36;

    public GameObject Enemy37;
    public EnemyHealth hp37;

    public GameObject Enemy38;
    public EnemyHealth hp38;

    public GameObject Enemy39;
    public EnemyHealth hp39;

    public GameObject Enemy40;
    public EnemyHealth hp40;

    public GameObject Enemy41;
    public EnemyHealth hp41;

    public GameObject Enemy42;
    public EnemyHealth hp42;

    public GameObject Enemy43;
    public EnemyHealth hp43;

    public GameObject Enemy44;
    public EnemyHealth hp44;

    public GameObject Enemy45;
    public EnemyHealth hp45;

    public GameObject Enemy46;
    public EnemyHealth hp46;

    public GameObject Enemy47;
    public EnemyHealth hp47;

    public GameObject Enemy48;
    public EnemyHealth hp48;

    public GameObject Enemy49;
    public EnemyHealth hp49;

    public GameObject Enemy50;
    public EnemyHealth hp50;



    public EnemyCounter ec;

    public void Death()
    {
        if (ec.count == 0)
        {
            Invoke("Respawn", 15f);
        }
    }

    void Respawn()
    {
        Enemy1.SetActive(true);
        hp1.health = 100f;
        
        Enemy2.SetActive(true);
        hp2.health = 100f;
        
        Enemy3.SetActive(true);
        hp3.health = 100f;
        
        Enemy4.SetActive(true);
        hp4.health = 100f;

        Enemy4.SetActive(true);
        hp4.health = 100f;

        Enemy5.SetActive(true);
        hp5.health = 100f;

        Enemy6.SetActive(true);
        hp6.health = 100f;

        Enemy7.SetActive(true);
        hp7.health = 100f;

        Enemy8.SetActive(true);
        hp8.health = 100f;

        Enemy9.SetActive(true);
        hp9.health = 100f;

        Enemy10.SetActive(true);
        hp10.health = 100f;

        Enemy11.SetActive(true);
        hp11.health = 100f;

        Enemy12.SetActive(true);
        hp12.health = 100f;

        Enemy13.SetActive(true);
        hp13.health = 100f;

        Enemy14.SetActive(true);
        hp14.health = 100f;

        Enemy15.SetActive(true);
        hp15.health = 100f;

        Enemy16.SetActive(true);
        hp16.health = 100f;

        Enemy17.SetActive(true);
        hp17.health = 100f;

        Enemy18.SetActive(true);
        hp18.health = 100f;

        Enemy19.SetActive(true);
        hp19.health = 100f;

        Enemy20.SetActive(true);
        hp20.health = 100f;

        Enemy21.SetActive(true);
        hp21.health = 100f;

        Enemy22.SetActive(true);
        hp22.health = 100f;

        Enemy23.SetActive(true);
        hp23.health = 100f;

        Enemy24.SetActive(true);
        hp24.health = 100f;

        Enemy25.SetActive(true);
        hp25.health = 100f;

        Enemy26.SetActive(true);
        hp26.health = 100f;

        Enemy27.SetActive(true);
        hp27.health = 100f;

        Enemy28.SetActive(true);
        hp28.health = 100f;

        Enemy29.SetActive(true);
        hp29.health = 100f;

        Enemy30.SetActive(true);
        hp30.health = 100f;

        Enemy31.SetActive(true);
        hp31.health = 100f;

        Enemy32.SetActive(true);
        hp32.health = 100f;

        Enemy33.SetActive(true);
        hp33.health = 100f;

        Enemy34.SetActive(true);
        hp34.health = 100f;
        
        Enemy35.SetActive(true);
        hp35.health = 100f;

        Enemy36.SetActive(true);
        hp36.health = 100f;

        Enemy37.SetActive(true);
        hp37.health = 100f;

        Enemy38.SetActive(true);
        hp38.health = 100f;

        Enemy39.SetActive(true);
        hp39.health = 100f;

        Enemy40.SetActive(true);
        hp40.health = 100f;

        Enemy41.SetActive(true);
        hp41.health = 100f;

        Enemy42.SetActive(true);
        hp42.health = 100f;

        Enemy43.SetActive(true);
        hp43.health = 100f;

        Enemy44.SetActive(true);
        hp44.health = 100f;

        Enemy45.SetActive(true);
        hp45.health = 100f;

        Enemy46.SetActive(true);
        hp46.health = 100f;

        Enemy47.SetActive(true);
        hp47.health = 100f;

        Enemy48.SetActive(true);
        hp48.health = 100f;

        Enemy49.SetActive(true);
        hp49.health = 100f;

        Enemy50.SetActive(true);
        hp50.health = 100f;

        ec.count = 50;
    }
}
