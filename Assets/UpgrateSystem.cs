using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgrateSystem : MonoBehaviour {

	public Player ply;
	public gameMaster gm;


	//private int weaponLvl;
	public int currentWeaponlvl = 1;
	private int weaponDmg;
	private int costlvl;

	//Text
	public Text DamageText;
	public Text CostText;
	public Text WeaponlvlUP;


	//Botones
	public Button btnPowerSwordone;


	void Start () {

		ply.weaponSwordOne = weaponDmg;

	
	}
	

	void Update () {


		if(currentWeaponlvl < 10)
		{
			if(currentWeaponlvl == 1)
			if (gm.coins >= costlvl)
				btnPowerSwordone.interactable = true;
			else
				btnPowerSwordone.interactable = false;
		}
		else
			btnPowerSwordone.interactable = false;

		costlvl = currentWeaponlvl * 5;
		//weaponDmg = currentWeaponlvl * 5;

		DamageText.text = ("Damage: " + " " + ply.weaponSwordOne);
		CostText.text = ("Cost: " + " " + costlvl);
		WeaponlvlUP.text = ("Level: " + currentWeaponlvl);
		Save();
		ply.Save ();
	}

	public void powerupSwordOne ()
	{

		gm.coins -= costlvl;
		ply.weaponSwordOne += 5;
		currentWeaponlvl++;
		ply.dmgUpdate = true;
	}

	public void Awake()
{
		if (PlayerPrefs.HasKey("currentWeaponlvl"))
	{
		//We had a previous seasion
			currentWeaponlvl= PlayerPrefs.GetInt("currentWeaponlvl");
	}
	else
		Save();
	

}

public void Save()
{
		PlayerPrefs.SetInt("currentWeaponlvl", currentWeaponlvl);
	
}
}
