using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;

public class CollectionDataBase : MonoBehaviour {
	private List<Item> database = new List<Item>();
	private JsonData itemData;
	private string jsonString;


	void Start()
	{
		//itemData = JsonMapper.ToObject(
		jsonString = File.ReadAllText(Application.dataPath + "/DBJson/Items.json").ToString(); 
		itemData = JsonMapper.ToObject (jsonString);
		//Application.dataPath + "/StreamingAssets/Items.json"
		//"jar:file://"+ Application.dataPath + "!/StreamingAssets/Items.json"

	//	ConstructItemDataBase ();
		Debug.Log(itemData["tittle"][0]);

	}

	/* void ConstructItemDataBase ()
	{
		for (int i = 0; i < itemData.Count; i++) 
		{
			database.Add (new Item(
				(int)itemData[i]["id"], 
				itemData[i]["tittle"].ToString(), 
				itemData[i]["slug"].ToString(), 
				(bool)itemData[i]["active"]
			));
		}
	}*/
}

public class Item
{
	public int ID { get; set;}
	public string Tittle { get; set;}
	public bool Active { get; set;}
	public Sprite Sprite { get; set;}
	public string Slug { get; set;}

	public Item(int id, string tittle, bool active, string slug)
	{
		this.ID = id;
		this.Tittle = tittle;
		this.Active = active;
		this.Slug = slug;
		this.Sprite = Resources.Load<Sprite> ("CollectionItemsSprites" + slug);
	}
	/*public Item()
	{
		this.ID = -1;
	}*/
}