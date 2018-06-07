using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadro : MonoBehaviour
{
    Rigidbody2D rb2d;
    string cuadro;
    public TextMesh TXT;

    // Use this for initialization
    void Start ()
    {
        int random = Random.Range(0, 2);
        cuadro=GameController.contenedor[random];
        Debug.Log(cuadro);
        TXT.text = cuadro + "";

        if (cuadro == GameController.personaje)
        {
            gameObject.tag = "1";
        }
        else
        {
            gameObject.tag = "2";

        }


        rb2d = GetComponent<Rigidbody2D>();
        

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (rb2d.transform.position.y < -8)
        {
            Destroy(gameObject);
        }


    }
}
