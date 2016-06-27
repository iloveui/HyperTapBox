using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour {

    public int coins = 0;
    public int mbCount = 0;
	public int gloveCount;
    public Text coinScore;
    public Text misteryBoxs;
	public Text gloves;
	public GameObject boxGlove;
    public GameObject shopMenu;
	public GameObject InvCon;
    private static gameMaster instance;
    public static gameMaster Instance { get { return instance; } }

    private void Start()
    {
		boxGlove.SetActive (false);
        shopMenu.SetActive(false);
		InvCon.SetActive(false);
    }
    void Update()
    {
		if (gloveCount > 0)
			boxGlove.SetActive (true);
		else
			boxGlove.SetActive (false);

       misteryBoxs.text = (" " + mbCount);
       coinScore.text = (" " + coins);
		gloves.text = (" " + gloveCount);
       Save();

    }
    public void Awake()
    {
		if (gloveCount > 0)
			boxGlove.SetActive (true);


        instance = this;
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.HasKey("Coins"))
        {
            //We had a previous seasion
            coins = PlayerPrefs.GetInt("Coins");

        }
        else
        {
            Save();
        }

        if (PlayerPrefs.HasKey("MBCount"))
        {
            //We had a previous seasion
            mbCount = PlayerPrefs.GetInt("MBCount");

        }
        else
        {
            Save();
        }
		if (PlayerPrefs.HasKey("GloveCount"))
		{
			//We had a previous seasion
			gloveCount = PlayerPrefs.GetInt("GloveCount");

		}
		else
		{
			Save();
		}

    }

    public void Save()
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetInt("MBCount", mbCount);
		PlayerPrefs.SetInt("GloveCount", gloveCount);
    }

    public void ToggleShopMenu ()
    {
        shopMenu.SetActive(!shopMenu.activeSelf);
    }
	public void ToggleInvCon ()
	{
		InvCon.SetActive(!InvCon.activeSelf);
	}
}
