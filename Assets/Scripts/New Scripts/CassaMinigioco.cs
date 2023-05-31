using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassaMinigioco : MonoBehaviour
{
    public GameObject enemyOrkey;
    public GameObject cassa;

    void Start()
    {
        enemyOrkey.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cassa.SetActive(false);
            enemyOrkey.SetActive(true);
        }
    }

}
