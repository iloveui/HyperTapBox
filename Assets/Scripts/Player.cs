using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int damage = 0;
    private gameMaster gm;
    private GameObject con;
    private GameObject mb;
	private GameObject glove;
	//public Text timeLeft;
	//private float startTime;
	//private float itemDuration;
	//float gloveTime = 3.0f;


	void Start()
    {
		//startTime = Time.time;
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		damage = 1;
    }

	void Update()
	{
	//	itemDuration = Time.time - startTime;
	//	string seconds = (itemDuration % 60).ToString ("00.00");
	//timeLeft.text = (" " +seconds);
	//gloveTime -= Time.deltaTime;

	//	if (gloveTime < 0) {
	//		damage -= 5;
	//	}
	
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
			Destroy(con.gameObject);
			gm.gloveCount += 1;
		} 
    }
}
