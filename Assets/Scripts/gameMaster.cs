using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour {

    public int coins = 0;
    public int mbCount = 0;
    public Text coinScore;
    public Text misteryBoxs;
    public GameObject shopMenu;
    private static gameMaster instance;
    public static gameMaster Instance { get { return instance; } }

    private void Start()
    {
        shopMenu.SetActive(false);
    }
    void Update()
    {
       misteryBoxs.text = (" " + mbCount);
       coinScore.text = (" " + coins);
       Save();

    }
    public void Awake()
    {
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

    }

    public void Save()
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetInt("MBCount", mbCount);
    }

    public void ToggleShopMenu ()
    {
        shopMenu.SetActive(!shopMenu.activeSelf);
    }
}
