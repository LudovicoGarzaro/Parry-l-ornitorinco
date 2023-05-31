using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoss : MonoBehaviour
{
    public Component bossdoorscollider;
    public GameObject key;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bossdoorscollider.GetComponent<BoxCollider>().enabled = true;
            key.SetActive(false);
        }
    }
}
