using UnityEngine;
using System.Collections;


public class TapBox : MonoBehaviour
{
    public int life = 20;
    private int dmg = 5;
    private float dropRate = 0.20f;
    public GameObject[] Items;

    void Start()
    {
        GameObject PlayerManager = GameObject.Find("PlayerManager");
        Player player = PlayerManager.GetComponent<Player>();
        player.damage = player.damage;
        dmg = player.damage;
    }
    void OnMouseDown()
    {

        life = life - dmg;
        
		
		int pickAnumber = Random.Range(1,3);//exclusive never prints the last only goes 1 to 2
        Debug.Log (pickAnumber);
		
		gameObject.GetComponent<Animator>().Play("Shake"+pickAnumber); //Play Random animation of shake
		
        print(life);
        if (life < 1)
        {
            //BoxCollider[] myColliders = gameObject.GetComponents<BoxCollider>();
            //foreach(BoxCollider bc in myColliders) bc.enabled = false;
            print(life);
			Destroy(gameObject, 0.10f);
			
            if (Random.Range(0.0f, 1.0f) <= dropRate)
            {
                Summon();
            }
        }
    }
    public void Summon()
    {
        int ItemsIndex = Random.Range(0, Items.Length);
        Instantiate(Items[ItemsIndex],transform.localPosition, Quaternion.identity);
    }
}