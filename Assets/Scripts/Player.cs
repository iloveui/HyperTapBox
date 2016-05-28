using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int damage = 0;
    private gameMaster gm;
    private GameObject con;
    private GameObject mb;

	void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
        damage = 10;

    }

    void OnMouseDown()
    {
        if (mb.CompareTag("MBOX"))
        {
            Destroy(mb.gameObject);
            gm.mbCount += 1;
        }

        if (con.CompareTag("coin"))
        {
            Destroy(con.gameObject);
            gm.coins += 1;
        } 
    }
}
