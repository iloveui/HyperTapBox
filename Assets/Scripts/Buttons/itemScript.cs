﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemScript : MonoBehaviour {

    public int cost;
    private gameMaster gm;

    public void BuyMB()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
        if (gm.coins >= cost)
        {
            gm.mbCount += 1;
            gm.coins -= cost;
        }

    }

	public void Cash()
	{
		gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		gm.coins += 10;
	}

	public void Glove()
	{
		gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		if (gm.coins >= cost)
		{
			gm.gloveCount += 1;
			gm.coins -= cost;
		}

	}
}