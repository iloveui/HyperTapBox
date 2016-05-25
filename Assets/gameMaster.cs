using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {

    public int coins;
    public Text coinScore;

    void Update()
    {
        coinScore.text = ("Coins: " + coins);
    }
}
