using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBossBattle : MonoBehaviour
{
    public GameObject tendone;
    public GameObject elDiabloPrima;
    public GameObject elDiabloDopo;
    public GameObject testo;
    public GameObject lavaFloor;
    public GameObject muroBlock;
    private float tempo = 7f;

    void Update()
    {
        tempo -= Time.deltaTime;

        if(tempo <= 0f)
        {
            tendone.SetActive(false);
            elDiabloPrima.SetActive(false);
            elDiabloDopo.SetActive(true);
            testo.SetActive(false);
            lavaFloor.SetActive(true);
            muroBlock.SetActive(false);
        }
    }
}
