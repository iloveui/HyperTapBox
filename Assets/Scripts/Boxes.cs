using UnityEngine;
using System.Collections;

public class Boxes : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject[] BoxPrefabs;


    public void SpwnBoxs()
    {
        int BoxIndex = Random.Range(0, BoxPrefabs.Length);
        Instantiate(BoxPrefabs[BoxIndex], spawnPoint.position, Quaternion.identity);
    }
}