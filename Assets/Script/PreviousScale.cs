using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousScale : MonoBehaviour
{
    private Vector3 newScale;
    public GameObject[] planets;
    // Start is called before the first frame update


    public void thePreviousScale()
    {
        newScale = new Vector3(1, 1, 1);

        for (int i = 0; i < planets.Length; i++)
        {
            if(planets[i].transform.localScale.x>=0.8 && planets[i].transform.localScale.y >= 0.8 && planets[i].transform.localScale.z >= 0.8)
            {
                planets[i].transform.localScale -= newScale;
            }
        }

    }
}
