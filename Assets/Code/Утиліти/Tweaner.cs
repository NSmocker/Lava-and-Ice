using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweaner : MonoBehaviour
{
    public GameObject twin_from;
    public bool use_position,use_angles,use_scale;
    public string update_method="Update";

    Quaternion prev_angles;
    Vector3 prev_position;


    void TweanPosition()
    {
        transform.localPosition =  prev_position;
        prev_position = twin_from.transform.position;
    }
    void TweanAngle()
    {
        transform.localRotation = prev_angles;
        prev_angles = twin_from.transform.rotation;
    }
    void TweanScale()
    {
         transform.localScale = twin_from.transform.lossyScale;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       if(update_method=="FixedUpdate")
        {
            if(use_position)TweanPosition();
            if(use_angles)TweanAngle();
            if(use_scale)TweanScale();
        }
    
    }

    void LateUpdate()
    {
        if(update_method=="LateUpdate")
        {
            if(use_position)TweanPosition();
            if(use_angles)TweanAngle();
            if(use_scale)TweanScale();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if(update_method=="Update")
        {
            if(use_position)TweanPosition();
            if(use_angles)TweanAngle();
            if(use_scale)TweanScale();
        }
        
        

    }
}
