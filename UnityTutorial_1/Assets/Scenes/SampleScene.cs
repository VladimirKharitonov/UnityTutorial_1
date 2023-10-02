using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    public GameObject gameObj;
    public void ChangeActive()
    {
        gameObj.SetActive(gameObj.activeSelf == true ? false : true);
    }
}
