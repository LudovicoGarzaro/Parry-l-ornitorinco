using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryMechanic : MonoBehaviour
{

    public GameObject player;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            player.GetComponent<Animator>().SetTrigger("ParryBotton");
        }
    }
}
