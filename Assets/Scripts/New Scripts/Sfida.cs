using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfida : MonoBehaviour
{
    public GameObject sfidaText;

    void Start()
    {
        sfidaText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        sfidaText.SetActive(true);
    }
}
