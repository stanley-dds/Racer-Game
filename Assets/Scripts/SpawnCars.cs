using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{

    public GameObject[] cars;
    private float[] positions = {1,55f,0.58f,-0.53f,-1.53f};
    void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {   
        while(true)
        {
            Instantiate(
                cars[Random.Range(0,cars.Length)],
                new Vector3(positions[Random.Range(0,4)], 6f,0),
                Quaternion.Euler(new Vector3(90,180,0))
            );

            //objects will be generated in every 0.5 secs
            yield return new WaitForSeconds(0.5f);
        }
    }
}
