using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject target;
    public float rotateSpeed = 5;
    Vector3 offset;

    void Start()
    {
        offset = target.transform.position - transform.position;
    }

    void Update() {
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerActions.tryToRaycast(target);
        }
        /* Debug DrawRay 
        else
        {
            Debug.DrawRay(target.transform.position, target.transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }*/
    }

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
    }
}
