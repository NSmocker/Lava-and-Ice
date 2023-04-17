using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionPointer : MonoBehaviour
{
    public TrackablesLibrary trackables_library;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var new_angle = new Vector3(0, trackables_library.eyes_trackable.transform.eulerAngles.y, 0);
        transform.eulerAngles = new_angle;
    }
}
