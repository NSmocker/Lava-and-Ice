using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsSystem : MonoBehaviour
{
    public GameObject hands_offset;
    public GameObject head_trackable;
    public Vector3 eyes_up_offset;

    public Transform left_hand_object,right_hand_object;
    public Transform left_hand_trackable, right_hand_trackable;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
         left_hand_object.transform.position = left_hand_trackable.transform.position;
         right_hand_object.transform.position = right_hand_trackable.transform.position;
         left_hand_object.transform.localRotation = left_hand_trackable.transform.localRotation;
         right_hand_object.transform.localRotation = right_hand_trackable.transform.localRotation;


        hands_offset.transform.localPosition = -head_trackable.transform.localPosition+ eyes_up_offset;// new Vector3(0, -head_trackable.transform.localPosition.y, 0);  
    }
}
