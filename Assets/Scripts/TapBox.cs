using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TapBox : MonoBehaviour
{
	public int life;
    private int dmg = 0;

	//public Button BoxButton;
	private Boxes box;
	private Player player;

    public float ComdropRate;
	public float UnCdropRate;
	public float RaredropRate;

    public GameObject[] CommonDrop;
	public GameObject[] UncommonDrop;
    public GameObject[] RareDrop;

    //public Transform spawnPoint;
    int minDrops = 1;
    int maxDrops = 3;
 

    void Start()
    {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		dmg = player.damage;

    }

		
	void Update()
	{
		dmg = player.damage;
	}


    void OnMouseDown()
    {
		
		life = life - dmg;
		
		int pickAnumber = Random.Range(1,4);//exclusive never prints the last only goes 1 to 3
        Debug.Log (pickAnumber);
		
		gameObject.GetComponent<Animator>().Play("Shake"+pickAnumber); //Play Random animation of shake
		
        print(life);
		if (life < 1)
        {
            print(life);
			box = GameObject.FindGameObjectWithTag ("SpawnButton").GetComponent<Boxes> ();
			box.buttonBox.interactable = true;
			Destroy(gameObject, 0.10f);

			if (Random.Range(0.0f, 1.0f) <= ComdropRate)
            {
                dropOnDeath();
            }
            else
            {
				if (Random.Range(0.0f, 1.0f) <= RaredropRate)
                {
                    rareDrop();
                }
				if (Random.Range(0.0f, 1.0f) <= UnCdropRate)
				{
					uncommonDrop ();
				}
      		}

		//switch (3) 
		//{
		//case 1:
			//return; break;
		//case 2:
			//break;
		//case 3:
			//break;
		//default:
			//break;
		//}
		}
    }
    public void dropOnDeath()
    {
        int pointRandom = Random.Range(-1,3);
        int numDrops = Random.Range(minDrops, maxDrops);
        for (int i = 0; i < numDrops; ++i)
        {
			int ItemsIndex = Random.Range(0, CommonDrop.Length);
			Instantiate(CommonDrop[ItemsIndex], transform.position, Quaternion.identity);
        }
    }

    public void rareDrop()
    {
		int rareItemsIndex = Random.Range(0, RareDrop.Length);
		Instantiate(RareDrop[rareItemsIndex], transform.position, Quaternion.identity);
    }

	public void uncommonDrop()
	{
		int uncommonItemsIndex = Random.Range(0, UncommonDrop.Length);
		Instantiate(UncommonDrop[uncommonItemsIndex], transform.position, Quaternion.identity);
	}
}