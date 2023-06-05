using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


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
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
        
        

        

        

    }

}
