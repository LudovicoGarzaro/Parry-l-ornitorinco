using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int currentHealth, maxHealth = 10;
    public AudioSource theme;
    public AudioSource gameOver;
    

   

    public GameObject deathscene;

    void Start()
    {
        currentHealth = maxHealth;

        theme.Play();
        
    }

   
    public void TakeDamagePlayer(int damageAmmountPlayer)
    {
        currentHealth -= damageAmmountPlayer;

       

        if(currentHealth <= 0)
        {
            deathscene.SetActive(true);
            Time.timeScale = 0f;
            theme.Stop();
            gameOver.Play();
            

        }

    }

}
