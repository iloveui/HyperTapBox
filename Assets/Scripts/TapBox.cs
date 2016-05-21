using UnityEngine;
using System.Collections;


public class TapBox : MonoBehaviour
{
    public int life = 20;
    private int dmg = 5;
    private float dropRate = 1.0f;
    public GameObject[] Items;
    



    void OnMouseDown()
    {
        life = life - dmg;
        gameObject.GetComponent<Animator>().Play("Shake");
        print(life);
        if (life < 1)
        {
            //BoxCollider[] myColliders = gameObject.GetComponents<BoxCollider>();
            //foreach(BoxCollider bc in myColliders) bc.enabled = false;
            Destroy(gameObject, 0.10f);
            print(life);
            if (Random.Range(0.0f, 1.0f) <= dropRate)
            {
                Summon();
            }
        }
    }
    public void Summon()
    {
        int ItemsIndex = Random.Range(0, Items.Length);
        Instantiate(Items[ItemsIndex],transform.position, Quaternion.identity);
    }
}