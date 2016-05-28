using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemScript : MonoBehaviour {

    public Image icon;
    public Image coin;
    public Text name;
    public int cost;
    public Button thisButton;
    private gameMaster gm;

    public void BuyMB()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
        if (gm.coins >= cost)
        {
            gm.mbCount += 1;
            gm.coins -= cost;
        }

    }
}
