using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Namesave : MonoBehaviour
{
    [SerializeField] TMP_InputField nam;
    [SerializeField] TMP_Text textview;
    void Savedata()
    {
        string data = nam.text;
        PlayerPrefs.SetString("inputname", data);
    }

    public void Showname()
    {
        textview.text = PlayerPrefs.GetString("inputname");
    }
}
