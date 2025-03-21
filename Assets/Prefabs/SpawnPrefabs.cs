using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject perro;
    // Start is called before the first frame update
    void Start()
    {
        generatePrefabs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generatePrefabs()
    {
        for (var i = 0; i < 100; i++)
        {
            
           Instantiate(perro, new Vector3(i*5, i*3, i * 10), Quaternion.identity);
        }
    }
}
