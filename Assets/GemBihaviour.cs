using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBihaviour : MonoBehaviour
{
    public const string lava_gem_type = "lava";
    public const string ice_gem_type = "ice";
    
    public string gem_type;

    GemSystem gem_system_link;

    // Start is called before the first frame update
    void Start()
    {
        gem_system_link = GameObject.Find("Gem System").GetComponent<GemSystem>();
        if(gem_system_link== null)Debug.LogError("Gem System not founded, gems cannot couts");    
    }

    void OnTriggerEnter(Collider touched_object)
    {
        if(touched_object.tag=="Player")
        {
            if(gem_type==lava_gem_type && touched_object.name.Contains("[Lava]"))gem_system_link.lava_gems++;
            if(gem_type==ice_gem_type  && touched_object.name.Contains("[Ice]"))gem_system_link.ice_gems++;
               
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
