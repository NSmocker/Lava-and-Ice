using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionPointerFromCamera : MonoBehaviour
{

    Vector3 custom_angles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        custom_angles = Camera.main.transform.eulerAngles;
        custom_angles.z = 0;
        custom_angles.x = 0;
        
        transform.eulerAngles = custom_angles;
    }
}
