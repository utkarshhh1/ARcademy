using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Backbutton : MonoBehaviour
{

    public string namee;

    public void SceanChanger(string namee)
    {
        SceneManager.LoadScene(namee);
    } 
}
