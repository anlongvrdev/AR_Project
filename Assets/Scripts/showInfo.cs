using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInfo : MonoBehaviour
{
    public GameObject plane1;
    public GameObject plane2;   
    public GameObject plane3;

    public void onShow1()
    {
        plane1.SetActive(true);
    }

    public void onShow2()
    {
        plane2.SetActive(true);
    }

    public void onShow3() 
    {
        plane3.SetActive(true);
    }
}
