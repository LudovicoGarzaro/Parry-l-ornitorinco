using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiocolore : MonoBehaviour
{


    public List<GameObject> muriesoffitto;

    Collider trigger;

    private void Awake()
    {
        trigger = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (trigger.gameObject.CompareTag("Player"))
        {
            muriesoffitto.Clear();
        }
    }
}

