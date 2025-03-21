using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class SpawnPrefabsOriginalPosition : MonoBehaviour
{
    public GameObject myPrefab;
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
        

            Instantiate(myPrefab, new Vector3(1, 5, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(1, 5, 3), Quaternion.identity);

    }
}
