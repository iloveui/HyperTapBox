using UnityEngine;
using System.Collections;
using System.IO;
using LitJson;

public class JsonFindData : MonoBehaviour {
	private string jsonString;
	private JsonData itemData;

	// Use this for initialization
	void Start () {
		jsonString = File.ReadAllText (Application.dataPath + "/Resources/Items.json".ToString());
		itemData = JsonMapper.ToObject (jsonString);

		Debug.Log (itemData["Item"][1]["name"]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
