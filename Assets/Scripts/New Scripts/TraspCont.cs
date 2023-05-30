using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraspCont : MonoBehaviour
{
    public GameObject container;
    public GameObject containerTrasparente;
    

    public Collider trigger;

    private void Start()
    {
        containerTrasparente.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            container.SetActive(false);
           
            containerTrasparente.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        container.SetActive(true);

        containerTrasparente.SetActive(false);
    }
}
