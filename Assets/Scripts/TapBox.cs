using UnityEngine;
using System.Collections;

public class TapBox : MonoBehaviour
{
    public int life = 20;
    private int dmg = 5;
    public GameObject CC;
    private float dropRate = 1.0f;


    void OnMouseDown()
    {
        life = life - dmg;
        print(life);
        if (life < 1)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
            print(life);
            if (Random.Range(0.0f, 1.0f) <= dropRate)
            {
                Summon();
            }
        }
    }
    public void Summon()
    {
        CC = Instantiate(Resources.Load("Box")) as GameObject;
    }
}