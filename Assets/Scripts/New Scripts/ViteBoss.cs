using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViteBoss : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Proiettile"))
        {
            Destroy(gameObject);
        }
    }
}
