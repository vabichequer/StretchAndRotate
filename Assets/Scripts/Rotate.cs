using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject RotationReference;
    public int Sensibility;

    /*
     * Monitors mouse drag events. Sensibility acts as speed rotation, where
     * increasing/decreasing it will make the object rotate faster/slower.
     */
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * Sensibility * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * Sensibility * Mathf.Deg2Rad;

        RotationReference.transform.Rotate(new Vector3(rotY, -rotX, 0));
    }
}
