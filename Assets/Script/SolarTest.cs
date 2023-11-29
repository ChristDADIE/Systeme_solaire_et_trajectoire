using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarTest : MonoBehaviour
{


    public Transform planetTransform;


    public void UpdatePosition(DateTime t)
    {

        

            Vector3 maPos = PlanetData.GetPlanetPosition((PlanetData.Planet) 1, t);


            planetTransform.position = maPos;

        

    }
    // Start is called before the first frame update
    void Start()
    {
        PlanetManager.current.OnTimeChange += UpdatePosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



