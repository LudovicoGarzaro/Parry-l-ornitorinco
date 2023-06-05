using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    
    public float chooseCannonTime = 1f;
    private float defaultTimeCannon;
    private GameObject cannoneRandom;

    public GameObject[] cannoni;

    

    private void Start()
    {

        defaultTimeCannon = chooseCannonTime;
        
    }
    void Update()
    {
        chooseCannonTime -= Time.deltaTime;

        if(chooseCannonTime <= 0f)
        {
            cannoneRandom = cannoni[Random.Range(0, cannoni.Length)];
            cannoneRandom.SetActive(true);
            chooseCannonTime = defaultTimeCannon;

            


        }

        
    }

}
