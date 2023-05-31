using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassaSpaccabile : MonoBehaviour
{
    public GameObject cassa;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cassa.SetActive(false);
        }
    }
}
