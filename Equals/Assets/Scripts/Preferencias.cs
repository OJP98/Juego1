using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Preferencias : MonoBehaviour
{
    GameObject pref1;
    GameObject pref2;


    // Use this for initialization
    void Start ()
    {
        pref1 = GameObject.Find("NumerosTgl");
        pref2 = GameObject.Find("LetrasTgl");



    }

    public void click()
    {
        if (pref1.GetComponent<Toggle>().isOn == true)
        {
            PlayerPrefs.SetInt("numeros", 1);
        }
        else
        {
            PlayerPrefs.SetInt("numeros", 0);
        }

        if (pref2.GetComponent<Toggle>().isOn == true)
        {
            PlayerPrefs.SetInt("letras", 1);
        }
        else
        {
            PlayerPrefs.SetInt("letras", 0);
        }

        SceneManager.LoadScene("Main");

    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
