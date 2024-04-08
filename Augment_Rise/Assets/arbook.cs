using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbook : MonoBehaviour
{
    public static arbook instance;
    [SerializeField]
    GameObject phyics;
    GameObject chemist;
    private void Awake()
    {
        CreateInstance();
    }

    private void CreateInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void physics()
    {
       phyics.SetActive(true);

    }
}
