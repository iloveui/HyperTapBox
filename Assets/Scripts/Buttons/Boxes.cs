using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Boxes : MonoBehaviour
{
    public GameObject[] BoxPrefabs;
	//nivel 1	public GameObject[] boxLvL1;
	//nivel 2	public GameObject[] boxLvL2;
	//nivel 3	public GameObject[] boxLvL3;
    private gameMaster gm;
    private GameObject mb;
	public Button buttonBox;



    public void Discount()
	{
		gm = GameObject.FindGameObjectWithTag ("GameMaster").GetComponent<gameMaster> ();

		if (gm.mbCount >= 1) {

			// Si los dos items estan activar nivel 2 si no seguir con el nivel 1
			// Caso, si tienes estos nada invocar esta lista, si tienes 2 items invocar esta otra lista, si tienes 3 items invocar esta otra lista
			int BoxIndex = Random.Range (0, BoxPrefabs.Length);
			Instantiate (BoxPrefabs [BoxIndex], transform.position, Quaternion.identity);
			gm.mbCount --;
			buttonBox.interactable = false;
		}
	}
}	