using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemCollec : MonoBehaviour {

	private Player player;


	[HideInInspector]public bool OneOne;
	public Image Item1;

	[HideInInspector]public bool TwoTwo;
	public Image Item2;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		OneOne = false;
		TwoTwo = false;
	}

	void Update ()
	{
		ONEItemsCollection ();
	
	}
		
	public void ONEItemsCollection ()
	{

		if (OneOne == true) {
			Item1.enabled = true;
		}

		if (TwoTwo == true) {
			Item2.enabled = true;
		}

		if(OneOne == true  &&  TwoTwo == true)
		{
			
			player.damage += 100;
			OneOne = false;
			TwoTwo = false;
		} 

	
	}
}
