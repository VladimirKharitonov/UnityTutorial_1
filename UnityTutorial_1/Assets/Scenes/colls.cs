using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colls : MonoBehaviour
{
    public Text lbl;
   
    int i;

    void Start()
    {
        lbl.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        --i;
        lbl.text = "" + i;
    }
}
