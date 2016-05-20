using UnityEngine;
using System.Collections;

public class TapBox : MonoBehaviour
{

    public int life = 20;
    private int dmg = 5;
    public GameObject CC;
    private float Delay = 0.5f;

    void OnMouseDown()
    {
        life = life - dmg;
        print(life);
        if (life < 1)
        {

            Summon();
            Destroy(gameObject,Delay);
            print(life);

            
        }
    }
 

    void  Summon()
    {
     
        CC = Instantiate(Resources.Load("Box"), transform.position, transform.rotation) as GameObject;

    }
}