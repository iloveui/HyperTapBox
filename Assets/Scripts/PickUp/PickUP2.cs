using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUP2 : MonoBehaviour {


	private int HP = 1;
	private int Dmg = 1;
	private ItemCollec IC;


	void Start()
	{
		IC = GameObject.FindGameObjectWithTag("CollectionItem").GetComponent<ItemCollec>();
	}

	public void OnMouseDown()
	{
		HP = HP - Dmg;
		if (HP < 1)
		{
			Destroy(gameObject);
			IC.TwoTwo = true;
		}
	}
}