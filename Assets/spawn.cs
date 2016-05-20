using UnityEngine;
using System.Collections;
using System;

public class spawn : MonoBehaviour
{
    public GameObject SPW;
  
    void OnClickMouse()
    {
       Invoke("SPW", 0.5f);
        
    }

}