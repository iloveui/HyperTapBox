using UnityEngine;
using System.Collections;

public class TapBox : MonoBehaviour
{

    private int pushPower = 2000;
    public int life = 200;
    private int selfDamage = 10;

    void OnMouseDown()
    {
        selfDamage = this.transform.GetComponent<damageScript>().damage;

        life = life - selfDamage;
        print(life);
        if (life < 1)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * pushPower);
            this.GetComponent<Rigidbody>().useGravity = true;
            //iTween.fadeTo(gameObject,{"alpha":0, "onComplete":"destroy"});
            Destroy(gameObject, 5);
            print(life);
        }
    }

}