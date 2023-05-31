using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaBoss : MonoBehaviour
{
    public GameObject porta1aperta;
    public GameObject porta2aperta;
    public GameObject porta1chiusa;
    public GameObject porta2chiusa;

    private void Start()
    {
        porta1aperta.SetActive(false);
        porta2aperta.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            porta1aperta.SetActive(true);
            porta2aperta.SetActive(true);
            porta1chiusa.SetActive(false);
            porta2chiusa.SetActive(false);
        }
    }
}
