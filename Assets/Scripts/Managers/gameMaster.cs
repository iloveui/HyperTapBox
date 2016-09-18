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
	public Button btnGlove;
    public GameObject shopMenu;
	public GameObject InvCon;
	public GameObject Collection;
	public GameObject Upgrate;
    private static gameMaster instance;
    public static gameMaster Instance { get { return instance; } }


    private void Start()
    {
		btnGlove.interactable = false;
        shopMenu.SetActive(false);
		InvCon.SetActive(false);
		Collection.SetActive(false);
    }
    void Update()
    {
		if (gloveCount > 0)
			btnGlove.interactable = true;
		else
			btnGlove.interactable = false;

       misteryBoxs.text = (" " + mbCount);
       coinScore.text = (" " + coins);
		gloves.text = (" " + gloveCount);
       Save();

    }
    public void Awake()
    {
		if (gloveCount > 0)
			btnGlove.interactable = true;


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
	public void ToggleBtnInv ()
	{
		Collection.SetActive(!Collection.activeSelf);
	}
	public void ToggleBtnUpgrate ()
	{
		Upgrate.SetActive(!Upgrate.activeSelf);
	}
}
