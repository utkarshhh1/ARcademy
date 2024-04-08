using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManger : MonoBehaviour
{
    public GameObject[] canvasScenes;
    
    void Start()
    {
  
        foreach (GameObject canvasScene in canvasScenes)
        {
            if (canvasScenes[3])
            {
                canvasScenes[3].SetActive(true);
            }
            else
            {
                canvasScene.SetActive(false);
            }
        }
    }


    public void back()
    {    
             canvasScenes[2].SetActive(true);
             canvasScenes[0].SetActive(false);
             canvasScenes[1].SetActive(false);
             canvasScenes[3].SetActive(false);
    }
  public void Physics()
    {
        foreach (GameObject canvasScene in canvasScenes)
        {
            if (canvasScenes[0])
            {
                canvasScenes[0].SetActive(true);
            }
            else
            {
                canvasScene.SetActive(false);
            }
        }
    }

    public void Chemistry()
    {
        foreach (GameObject canvasScene in canvasScenes)
        {
            if (canvasScenes[1])
            {
                canvasScenes[1].SetActive(true);
            }
            else
            {
                canvasScene.SetActive(false);
            }
        }
    }

}
