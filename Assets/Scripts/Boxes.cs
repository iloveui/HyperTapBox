using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boxes : MonoBehaviour
{
    public GameObject[] BoxPrefabs;
    private gameMaster gm;
    private GameObject mb;
	public Button buttonBox;


    public void Discount()
	{
		gm = GameObject.FindGameObjectWithTag ("GameMaster").GetComponent<gameMaster> ();

		if (gm.mbCount >= 1) {
			int BoxIndex = Random.Range (0, BoxPrefabs.Length);
			Instantiate (BoxPrefabs [BoxIndex], transform.position, Quaternion.identity);
			gm.mbCount -= 1;
			buttonBox.interactable = false;
		}
	}
}	