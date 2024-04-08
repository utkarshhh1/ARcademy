using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamburgeer : MonoBehaviour
{
    public GameObject enbl;
    public GameObject disabl;
    public GameObject pnl;

    public bool front, back;
    public float speed;
    public float tempmenu;
    void Start()
    {
        pnl.transform.position = disabl.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (front)
        {
            pnl.transform.position = Vector3.Lerp(pnl.transform.position, enbl.transform.position, speed * Time.deltaTime);
            if (pnl.transform.localPosition.x == tempmenu)
            {
                front = false;
                pnl.transform.position = enbl.transform.position;
                tempmenu = -9999999.9f;
            }
            if (front)
            {
                tempmenu = pnl.transform.position.x;
            }

        }

        if (back)
        {
            pnl.transform.position = Vector3.Lerp(pnl.transform.position, disabl.transform.position, speed * Time.deltaTime);
            if (pnl.transform.localPosition.x == tempmenu)
            {
                back = false;
                pnl.transform.position = disabl.transform.position;
                tempmenu = -9999999.9f;
            }
            if (back)
            {
                tempmenu = pnl.transform.position.x;
            }

        }
    }
    public void movepanl()
    {
        back = false;
        front = true;
    }
    public void movepanlback()
    {
        back = true;
        front = false;
    }

}


