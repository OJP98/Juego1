using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadrosSpawner : MonoBehaviour
{
    public GameObject cuadro;

    public float spawnTime = 0.2f;
    public float elapsedTime = 0f;




    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime / 10;
        }
        else
        {

            Instantiate(cuadro, new Vector3(-2.12f, 7.9f, 0f), Quaternion.identity);
            Instantiate(cuadro, new Vector3(0f, 7.9f, 0f), Quaternion.identity);
            Instantiate(cuadro, new Vector3(2.12f, 7.9f, 0f), Quaternion.identity);
            elapsedTime = 0;

        }

    }
}
