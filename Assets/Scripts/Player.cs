using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int damage = 1;

    private gameMaster gm;
    private GameObject con;
    private GameObject mb;
	private GameObject glove;

	public Text timeLeft;
	private float itemDuration;
	float gloveTime = 3.0f;



	void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		damage = 1;
    }

	void Update()
	{
		string seconds = (itemDuration % 60).ToString ("00.00");

			//Glove Time
		if (damage > 1) {
				timeLeft.gameObject.SetActive (true);
				itemDuration = gloveTime -= Time.deltaTime;
				timeLeft.text = "" + seconds;
				if (itemDuration < 0) {
					damage -= 5;
					gloveTime = 3.0f;
					timeLeft.gameObject.SetActive (false);
				}
			}
	}

	public void GloveAttack()
	{
		if (gm.gloveCount > 0)
		{
			damage += 5;
			gm.gloveCount -= 1;
		}
	}

    void OnMouseDown()
    {
        if (mb.CompareTag("MBOX"))
        {
            Destroy(mb.gameObject);
            gm.mbCount += 1;
        }

        if (con.CompareTag("coin"))
        {
            Destroy(con.gameObject);
            gm.coins += 1;
        } 
		if (glove.CompareTag("LootItem"))
		{
			Destroy(glove.gameObject);
			gm.gloveCount += 1;
		} 
    }
}
