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



	void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		gloveTime = gloveTimeLeft;
		damage = 1;
		gloveActive = false;
    }

	void Update()
	{
		string seconds = (itemDuration % 60).ToString ("00.00");


			//Glove Time
		if (gloveActive == true) {
			timeLeft.gameObject.SetActive (true);
			itemDuration = gloveTimeLeft -= Time.deltaTime;
				timeLeft.text = "" + seconds;
				if (itemDuration < 0) {
					damage -= gloveDmg;
					gloveTimeLeft = gloveTime;
					timeLeft.gameObject.SetActive (false);
					gloveActive = false;
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
