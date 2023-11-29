using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trajet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] planetObjects;
    private LineRenderer[] lineRenderer;



   /* void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            lineRenderer[i] = GetComponent<LineRenderer>();
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        

        for (int i = 0; i < planetObjects.Length; i++)
        {
            Vector3 newPosition = planetObjects[i].transform.position;
        }

    }
}
