using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour

{
    public GameObject[] animalPerfabs;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPerfabs.Length);

            Instantiate(animalPerfabs[animalIndex], new Vector3(0, 0, 20), animalPerfabs[animalIndex].transform.rotation);
        }

    }
}
