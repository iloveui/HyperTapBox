using UnityEngine;
using System.Collections;

public class mbPickUp : MonoBehaviour {

    private int mbHP = 1;
    private int dmgOnMB = 1;
    private gameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }

    public void OnMouseDown()
    {
        mbHP = mbHP - dmgOnMB;
        if (mbHP < 1)
        {
            Destroy(gameObject);
            gm.mbCount += 1;
        }
    }
}
