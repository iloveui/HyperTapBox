using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LootManager : MonoBehaviour {

	public List<Loot> loot = new List<Loot> ();
	public List<GameObject> spawnPoints = new List<GameObject> ();
//	 private float InstantiationTimer = 2f;


	public void LootDrop ()
	{
		for (int i = 0; i < loot.Count; i++) 
		{
			if (Random.value * 100 < loot [i].spawnChance) 
			{
				int numDrops = Random.Range(loot[i].minDrop, loot[i].maxDrop);
				for (int d = 0; d < numDrops; d++)
				{
					Instantiate (loot [i].lootObject, spawnPoints[Random.Range(0,spawnPoints.Count)]. transform.position, Quaternion.identity);
				}
			}
		}
	}
	
	//spawnPoints [Random.Range (0, spawnPoints.Count)]
}
[System.Serializable]
public class Loot
{
	public GameObject lootObject;
	public int minDrop;
	public int maxDrop;
	public float spawnChance;
}