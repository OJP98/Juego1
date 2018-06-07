using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public static string[] contenedor= new string[3];
    public static string personaje;
    public Text personajeTXT;
    public static GameController instance;

    // Use this for initialization
    void Start ()
    {
        instance = this;

        if (PlayerPrefs.GetInt("numeros") == 1)
        {
            contenedor[0] = "1";
            contenedor[1] = "2";
            contenedor[2] = "3";
        }
        else
        {
            contenedor[0] = "a";
            contenedor[1] = "b";
            contenedor[2] = "c";
        }

        int random = Random.Range(0, 2);
        
        switch (random)
        {
            case 0:
                personaje = contenedor[0];
                break;
            case 1:
                personaje = contenedor[1];
                break;
            case 2:
                personaje = contenedor[2];
                break;

        }

        personajeTXT.text = personaje + "";
        


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
