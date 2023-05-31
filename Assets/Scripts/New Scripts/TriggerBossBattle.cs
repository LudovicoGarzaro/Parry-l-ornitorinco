using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBossBattle : MonoBehaviour
{
    

    public GameObject colliderMuro;

    public GameObject livello;

    private void Start()
    {
        colliderMuro.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        colliderMuro.SetActive(true);
        livello.SetActive(false);
    }

}
