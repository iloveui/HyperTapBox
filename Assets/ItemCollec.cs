using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemCollec : MonoBehaviour {

	private Player player;
	[HideInInspector]public int numItem;
	[HideInInspector]public int numItem1;
	[HideInInspector]public int numItem2;



	[HideInInspector]public bool OneOne	= false;
	public Image Item1;

	[HideInInspector]public bool TwoTwo = false;
	public Image Item2;



	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();

	}

	void Update()
	{
		if (numItem1 >= 1)
			numItem1 = 1;
		if (numItem2 >= 1)
			numItem2 = 1;

		numItem = numItem1 + numItem2;
	}
	void FixedUpdate ()
	{
		
		CollectionONE ();
	}
		
	public void CollectionONE ()
	{

		if (OneOne == true) {
			Item1.enabled = true;
		}

		if (TwoTwo == true) {
			Item2.enabled = true;
		}

		if (numItem == 2) {
			if (OneOne == true && TwoTwo == true) {
			
				player.damage += 10;
				OneOne = false;
				TwoTwo = false;
			} 
		}
	}
}
