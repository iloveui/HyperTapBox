using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int damage = 1;
	public int gloveDmg;

    private gameMaster gm;
    //private GameObject con;
    //private GameObject mb;
	//private GameObject glove;

	public Text timeLeft;
	private float itemDuration;
	float gloveTime;
	public float gloveTimeLeft;
	private bool gloveActive;


	public Text playerDmgText;
	public float DmgText;

	// Armas permanentes
	public int weaponHandDamage = 0;
	public Button btnHand;

	public int weaponSwordOne = 0;
	public Button btnSwordOne;

	public int weaponSuper = 0;
	public Button btnSuper;

	void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		gloveTime = gloveTimeLeft;
		damage = 1;
		gloveActive = false;

		playerDmgText.text = damage.ToString ();
    }

	void Update()
	{
		string seconds = (itemDuration % 60).ToString ("00.00");


			//Glove Time
		if (gloveActive == true) {
			gm.btnGlove.interactable = false;
			timeLeft.gameObject.SetActive (true);
			itemDuration = gloveTimeLeft -= Time.deltaTime;
			timeLeft.text = "" + seconds;
			playerDmgText.text = damage.ToString ();
				if (itemDuration < 0) {
					damage -= gloveDmg;
					playerDmgText.text = damage.ToString ();
					gloveTimeLeft = gloveTime;
					timeLeft.gameObject.SetActive (false);
					gloveActive = false;
					gm.btnGlove.interactable = true;
				}
			}
	}

	public void GloveAttack()
	{
		gloveActive = true;
		if (gm.gloveCount > 0)
		{
			damage += gloveDmg;
			gm.gloveCount -= 1;
		}
	}

	// Armas permanentes
	public void WeaponHand()
	{
		damage += weaponHandDamage;
		playerDmgText.text = damage.ToString ();
		btnHand.interactable = false;
	}

	public void SwordOne()
	{
		damage += weaponSwordOne;
		playerDmgText.text = damage.ToString ();
		btnSwordOne.interactable = false;
	}

	public void Super()
	{
		damage += weaponSuper;
		playerDmgText.text = damage.ToString ();
		btnSuper.interactable = false;
	}
		
    void OnMouseDown()
    {
		if (gameObject.CompareTag("MBOX"))
        {
			Destroy(gameObject.gameObject);
            gm.mbCount += 1;
        }

		if (gameObject.CompareTag("coin"))
        {
			Destroy(gameObject.gameObject);
            gm.coins += 1;
        } 
		if (gameObject.CompareTag("LootItem"))
		{
			Destroy(gameObject.gameObject);
			gm.gloveCount += 1;
		} 
    }
}
