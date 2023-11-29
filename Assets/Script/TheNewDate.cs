using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheNewDate : MonoBehaviour
{
    private DateTime inputDate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeDate(string s)
    {
        if (DateTime.TryParse(s, out inputDate))
        {
             Debug.Log("ok");
             Debug.Log(inputDate);
             PlanetManager.current.Date = inputDate;

        }
        else
        {
            Debug.Log("echec");
        }


    }
}
