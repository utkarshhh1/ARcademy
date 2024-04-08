using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceanchanger : MonoBehaviour
{
    public string sceaname;

    void gotonext()
    {
        SceneManager.LoadScene(sceaname);
    }
}
