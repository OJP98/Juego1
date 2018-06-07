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
            int random1 = Random.Range(1,3);

            switch (random1)
            {
                
                case 1:
                    int random2 = Random.Range(1, 3);
                    switch (random2)
                    {
                        case 1:
                            Instantiate(cuadro, new Vector3(-2.12f, 7.9f, 0f), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(cuadro, new Vector3(0f, 7.9f, 0f), Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(cuadro, new Vector3(2.12f, 7.9f, 0f), Quaternion.identity);
                            break;


                    }
                    break;

                case 2:
                    int random3 = Random.Range(1, 3);
                    switch (random3)
                    {
                        case 1:
                            Instantiate(cuadro, new Vector3(-2.12f, 7.9f, 0f), Quaternion.identity);
                            Instantiate(cuadro, new Vector3(0f, 7.9f, 0f), Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(cuadro, new Vector3(-2.12f, 7.9f, 0f), Quaternion.identity);
                            Instantiate(cuadro, new Vector3(2.12f, 7.9f, 0f), Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(cuadro, new Vector3(2.12f, 7.9f, 0f), Quaternion.identity);
                            Instantiate(cuadro, new Vector3(0f, 7.9f, 0f), Quaternion.identity);
                            break;


                    }
                    break;
                case 3:
                    Instantiate(cuadro, new Vector3(-2.12f, 7.9f, 0f), Quaternion.identity);
                    Instantiate(cuadro, new Vector3(0f, 7.9f, 0f), Quaternion.identity);
                    Instantiate(cuadro, new Vector3(2.12f, 7.9f, 0f), Quaternion.identity);

                    break;
            }
            elapsedTime = 0;

        }

    }
}
