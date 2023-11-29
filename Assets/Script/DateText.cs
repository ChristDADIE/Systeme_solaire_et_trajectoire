using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class date : MonoBehaviour
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

    public void ChangeDate(string date)
    {


        if (DateTime.TryParse(date, out inputDate))
        {
            inputDate = DateTime.Parse(date);
            PlanetManager.current.Date = inputDate;
            PlanetManager.current.Date = PlanetManager.current.Date.dateTime.AddDays(1);
        } 



    }
}
