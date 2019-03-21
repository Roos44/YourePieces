using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ObjectOnGaol : MonoBehaviour
{
    public Text scoretext;
    public int hoeveelheid;
    public int winHoeveelheid = 3;
    public GameObject WinPanel;
    void Update()
    {

        scoretext.text = "collected " + hoeveelheid +"/" + winHoeveelheid;


    }


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Collecteble") hoeveelheid++;


        if (hoeveelheid >= winHoeveelheid)
        {

            WinPanel.SetActive(true);

        }

      }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Collecteble") hoeveelheid--;
    }




}
