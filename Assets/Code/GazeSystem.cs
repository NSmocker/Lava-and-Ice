using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeSystem : MonoBehaviour
{
    public GameObject looking_at;

    TooltipSystem tooltip;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit_info;
        var see_something = Physics.Raycast(transform.position,transform.forward, out hit_info, 5f);
        if (see_something)
        {
            looking_at = hit_info.collider.gameObject;
        }
        else 
        {
            looking_at = null;
        }
        if(looking_at != null )GazeLogic();



    }

    void GazeLogic()
    {
        if (looking_at.tag == "Табличка з підказкою")
        {
        //   if(tooltip==) // var tooltip_link = looking_at.GetComponent<TooltipSystem>();
        }

    }
}
