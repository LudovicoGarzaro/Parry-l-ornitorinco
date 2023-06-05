using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannoneBoss : MonoBehaviour
{

    public GameObject[] bullets;
    public float timeBetweenAtks = 1f;
    private float ResetAtks;
    private GameObject proiettile;

    public Transform bulletsSpawn;
    public float bulletSpeed = 5;

    public float despawnTime = 2f;
    private float defaultDeTi;

    public void Start()
    {
        ResetAtks = timeBetweenAtks;
        gameObject.SetActive(false);
        defaultDeTi = despawnTime;
    }


    void Update()
    {
        timeBetweenAtks -= Time.deltaTime;
        despawnTime -= Time.deltaTime;

        if(timeBetweenAtks <= 0f)
        {
            
            proiettile = Instantiate(bullets[Random.Range(0, bullets.Length)], bulletsSpawn.localPosition, bulletsSpawn.localRotation);
            timeBetweenAtks = ResetAtks;

            proiettile.GetComponent<Rigidbody>().velocity = bulletsSpawn.up * bulletSpeed;

        }

        if(despawnTime <= 0f)
        {
            gameObject.SetActive(false);
            despawnTime = defaultDeTi;
        }
    }

}
