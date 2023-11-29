using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour
{
    public Transform target;
    private Camera mainCamera;
    private bool isObjectCentered = false;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    target = hit.transform;
                    isObjectCentered = true;
                }
            }
        }

        if (isObjectCentered && target != null)
        {
            Vector3 targetPosition = target.position;
            targetPosition.z = mainCamera.transform.position.z-1;
            mainCamera.transform.position = targetPosition;
        }
    }
}
