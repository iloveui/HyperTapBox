using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TapBox : MonoBehaviour
{
    public int life = 20;
    private int dmg = 0;
    private float dropRate = 0.56f;
    public GameObject[] Items;
    public GameObject[] RareItems;
    public Transform spawnPoint;
    int minDrops = 1;
    int maxDrops = 3;
 

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
                dropOnDeath();
            }
            else
            {
                if (Random.Range(0.0f, 1.0f) <= 0.1)
                {
                    rareDrop();
                }
                
            }
        }
    }
    public void dropOnDeath()
    {
        int pointRandom = Random.Range(1,3);
        int numDrops = Random.Range(minDrops, maxDrops);
        for (int i = 0; i < numDrops; ++i)
        {
            int ItemsIndex = Random.Range(0, Items.Length);
            Instantiate(Items[ItemsIndex], transform.TransformVector(pointRandom,1,0), Quaternion.identity);
        }
    }

    public void rareDrop()
    {
        int rareItemsIndex = Random.Range(0, RareItems.Length);
        Instantiate(RareItems[rareItemsIndex], transform.position, Quaternion.identity);
    }
}