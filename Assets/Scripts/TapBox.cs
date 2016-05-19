using UnityEngine;
using System.Collections;

public class TapBox : MonoBehaviour
{

    public int life = 20;
    private int dmg = 5;
    public GameObject CC;


    void OnMouseDown()
    {
        life = life - dmg;
        print(life);
        if (life < 1)
        {
            Summon();
            Destroy(gameObject, 1);
            print(life);
        }
    }
    void Summon()
    {
        CC = Instantiate(Resources.Load("Box")) as GameObject;
    }
}