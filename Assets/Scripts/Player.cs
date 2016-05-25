using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int damage = 0;
    private gameMaster gm;
    private GameObject con;

	void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
        damage = 10;

    }

    void OnMouseDown()
    {
        
        if (con.CompareTag("coin"))
        {
            Destroy(con.gameObject);
            gm.coins += 1;
        } 
    }
}
