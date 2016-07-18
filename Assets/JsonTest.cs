using UnityEngine;
using System.Collections;
using LitJson;
using System.IO;

public class JsonTest : MonoBehaviour {
	public Character player = new Character(0,"Diamante", 100, false, new int[] {5,5,6,8});
	JsonData playerJson;


	void Start () 
	{
		playerJson = JsonMapper.ToJson (player);
		File.WriteAllText (Application.dataPath + "/tets.json",playerJson.ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


public class Character{
	public int id;
	public string name;
	public int health;
	public bool aggressive;
	public int[] stats;

	public Character(int id, string name, int health, bool aggressive, int[] stats)
	{
		this.id = id;
		this.name = name;
		this.health = health;
		this.aggressive = aggressive;
		this.stats = stats;
	}

}