using UnityEngine;
using System.Collections;

public class TapBox : MonoBehaviour
{

    public int life = 20;
    private int dmg = 50;

    void OnMouseDown()
    {
        life = life - dmg;
        print(life);
        if (life < 1)
        {
         
            Destroy(gameObject,0.5f);
            print(life);
        }
    }

}