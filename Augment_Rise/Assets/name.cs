using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class name : MonoBehaviour
{
    public Namesave namesc;
    public TMP_Text nametext; 
   public void nameshow()
    {
        nametext.text=PlayerPrefs.GetString("inputname");
    }
}
