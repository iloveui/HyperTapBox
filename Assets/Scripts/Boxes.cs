using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour {

    public GameObject[] BoxPrefabs;
    public void SpwnBoxs()
    {
    
            Instantiate(BoxPrefabs[Random.Range(0,BoxPrefabs.Length)],transform.position,Quaternion.identity);

    }
}