using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassaMinigioco : MonoBehaviour
{
    
    public GameObject spawnRef;
    public GameObject cassa;

    private void Start()
    {
        spawnRef.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cassa.SetActive(false);

            spawnRef.SetActive(true);
        }

    }


}
