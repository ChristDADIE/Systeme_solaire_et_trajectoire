using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraObjectArround : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPlanet;
    public float speed = 5f;
    private Vector3 coordPlanet;
    public float zoomspeed = 10f;
    private Quaternion initialRotation;
    private Vector3 initialPosition;
    void Start()
    {
        coordPlanet = myPlanet.transform.position;


        transform.LookAt(coordPlanet);
        initialRotation = transform.rotation;
        initialPosition = transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.B))
        {
            // le et right pour faire mes rotations
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.RotateAround(coordPlanet, Vector3.up, 20 * Time.deltaTime * speed);
            }


            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.RotateAround(coordPlanet, Vector3.down, 20 * Time.deltaTime * speed);
            }

            float dist = Vector3.Distance(transform.position, coordPlanet);

            // fleche du haut pour le zoom
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (dist > 1.5)
                {
                    transform.position += transform.forward * zoomspeed * Time.deltaTime;

                }

            }

            // fleche du bas pour le zoom
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (dist < 1000)
                {
                    transform.position -= transform.forward * zoomspeed * Time.deltaTime;

                }
            }
        }
        else if (Input.GetKey(KeyCode.N)) {

            transform.position = initialPosition;
            transform.rotation = initialRotation;
            
        }

    }
}
