using UnityEngine;
using System.Collections;

public class TapCoin : MonoBehaviour {
    private int HPCoin = 1;
    private int dmgOnCoin = 1;
    private gameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }

    public void OnMouseDown()
        {
        HPCoin = HPCoin - dmgOnCoin;
        if (HPCoin < 1)
            {
            Destroy(gameObject);
            gm.coins += 1;
            }
        }
}
