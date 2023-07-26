using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayerSystem : MonoBehaviour
{
    public GameObject red_character;
    public GameObject blue_character;

    public GameObject character_to_controll;
    
    // Start is called before the first frame update

    void Awake()
    {
       
    }
    void Start()
    { /*
        if(NetworkManager.Singleton.IsHost)
        {
            character_to_controll= red_character;
            
        }else
        {
            character_to_controll= blue_character;
        }
        
        transform.position = character_to_controll.transform.position;        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
