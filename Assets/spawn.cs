using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{

    public GameObject SPW;
    // Use this for initialization
    void OnClickEvent()
    {
        Invoke("SPW", 0.5f);
        
    }
    void spw()
    {
        SPW = Instantiate(Resources.Load("Box"), 0, 9, 0, Quaternion.Euler(0, 9, 0)) as GameObject;
    }

}