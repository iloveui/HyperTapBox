using UnityEngine;
using System.Collections;

public class TapCoin : MonoBehaviour {
    private int HPCoin = 1;
    private int dmgOnCoin = 1;
    private gameMaster gm;
	public AudioSource sfx;
	public Collider c;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		Collider c = GetComponentInChildren<Collider>();
		sfx = GetComponent<AudioSource>();

    }

    public void OnMouseDown()
        {
        HPCoin = HPCoin - dmgOnCoin;
		sfx.Play();
		gameObject.GetComponent<Animator>().Play("PickUp");
        if (HPCoin < 1)
            {
			c.enabled = false;
            Destroy(gameObject, 2);
            gm.coins += 1;
            }
        }
}
