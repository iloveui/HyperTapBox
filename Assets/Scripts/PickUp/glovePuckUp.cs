using UnityEngine;
using System.Collections;

public class glovePuckUp : MonoBehaviour {

	private int gloveHP = 1;
	private int dmgOnGlove = 1;
	private gameMaster gm;

	void Start()
	{
		gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
	}

	public void OnMouseDown()
	{
		gloveHP = gloveHP - dmgOnGlove;
		if (gloveHP < 1)
		{
			Destroy(gameObject);
			gm.gloveCount += 1;
		}
	}
}