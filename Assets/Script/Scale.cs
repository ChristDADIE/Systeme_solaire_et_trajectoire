using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour

{

    private Vector3 newScale;
    public GameObject[] planets;
    // Start is called before the first frame update


    public void theNewchangingScale()
    {
        newScale = new Vector3(1, 1, 1);

        for (int i = 0; i < planets.Length; i++) {

            planets[i].transform.localScale += newScale; 
        
        }

    }
}
