using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StandButton : MonoBehaviour
{

    public List<GameObject> objects_inside;

    public GameObject activate_if_standing;


    void OnTriggerStay(Collider touch)
    {
        if(!objects_inside.Contains( touch.gameObject))
        {
            objects_inside.Add(touch.gameObject);
        }
    }

    void OnTriggerExit(Collider touch)
    {
        if(objects_inside.Contains(touch.gameObject))
        {
            objects_inside.Remove(touch.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       activate_if_standing.SetActive(objects_inside.Count!=0);
    }
}
