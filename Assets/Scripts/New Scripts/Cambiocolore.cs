using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiocolore : MonoBehaviour
{


    public GameObject muro;
    public GameObject soffitto;
    public GameObject muroTrasparente;
    public GameObject soffittoTrasparente;
    public GameObject elMascherado;

    public Collider trigger;

    private void Start()
    {
        muroTrasparente.SetActive(false);
        soffittoTrasparente.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            muro.SetActive(false);
            soffitto.SetActive(false);
            muroTrasparente.SetActive(true);
            soffittoTrasparente.SetActive(true);
            elMascherado.SetActive(false);
        }
    }
}

