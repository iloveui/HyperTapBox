using UnityEngine;
using System.Collections;

public class TapCoin : MonoBehaviour {
    private int HPCoin = 1;
    private int dmgOnCoin = 1;
    private int timer = 0;
    private gameMaster gm;
	public AudioSource sfx;
	public Collider c;
    private bool flag = true;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		Collider c = GetComponentInChildren<Collider>();
		sfx = GetComponent<AudioSource>();

    }

    void Update () {
        if (flag){
            if (timer>200){
                flag = false;
                c.enabled = false;
                gm.coins += 1;
                sfx.Play();
                gameObject.GetComponent<Animator>().Play("PickUp");
                Destroy(gameObject, 1);
           } else {
                timer ++;
            }
        }
  } 


    public void OnMouseDown()
        {
        HPCoin = HPCoin - dmgOnCoin;
		sfx.Play();
		gameObject.GetComponent<Animator>().Play("PickUp");
        if (HPCoin < 1)
            {
			c.enabled = false;
            gm.coins += 1;
            Destroy(gameObject, 1);
            }
        }
}


