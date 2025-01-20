using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInfo : MonoBehaviour
{
    public GameObject plane1;
    public GameObject plane2;   
    public GameObject plane3;

    public GameObject gameObject;

    public void onShow1()
    {
        plane1.SetActive(true);
        plane2.SetActive(false);
        plane3.SetActive(false);
    }

    public void onShow2()
    {
        plane1.SetActive(false);
        plane2.SetActive(true);
        plane3.SetActive(false);
    }

    public void onShow3() 
    {
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(true);
    }

    public void onOff()
    {
        plane1.SetActive(false);
        plane2.SetActive(false);
        plane3.SetActive(false);
    }    

    public void showgameObject()
    {
        gameObject.SetActive(true);
    }
}
