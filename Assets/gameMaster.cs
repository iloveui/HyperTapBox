using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour {

    public int coins = 0;
    public int totalCoins = 0;
    public Text coinScore;
    private static gameMaster instance;
    public static gameMaster Instance { get { return instance; } }

    void Update()
    {
       coinScore.text = ("Coins: " + coins);
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

    }

    public void Save()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }
}
