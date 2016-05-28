using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.Events;


public class ShopMenu : MonoBehaviour
{

    [System.Serializable]
    public class Item
    {
        public string name;
        public Sprite image;
        public Sprite coin;
        public float cost;

        //public Button.ButtonClickedEvent btnClicked;
    }

    public gameMaster costes;
    public GameObject buttonItems;
    public Item[] shopItems;

    public GameObject button;

    void Start()
    {

        //    foreach (Item i in shopItems)
        //    {
        //   GameObject btn = (GameObject) Instantiate(button);
        //  itemScript scp = btn.GetComponent<itemScript>();
        //    scp.name.text = i.name;
        //  scp.icon.sprite = i.image;
        //   scp.coin.sprite = i.coin;
        //       scp.cost.text = "Cost: " + i.cost.ToString("F1");
        //scp.thisButton.onClick = i.btnClicked;
        //Item thisItem = i;
        //scp.thisButton.onClick.AddListener(()=> Purchase(thisItem));
        //btn.transform.SetParent(this.transform);//
    }
    //    }
    //  void Purchase(Item bought)
    //   {
    //    bought.cost = bought.cost * 1f;
    //  }
    // }

    void Update()
    {
   
          
    }
}
