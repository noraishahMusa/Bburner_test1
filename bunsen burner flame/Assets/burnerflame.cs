using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burnerflame : MonoBehaviour
{
    private ParticleSystem Bflame;


    // Start is called before the first frame update
    void Start()
    {
        Bflame.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) ;
        {
            Bflame.Play();
        }
        if (Input.GetMouseButtonUp(0)) ;
        {
            Bflame.Stop();
        }
    }
}