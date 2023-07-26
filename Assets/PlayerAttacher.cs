using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerAttacher : MonoBehaviour
{
   
    public CharacterXRLimbManager red_player,blue_player;
    


    // Start is called before the first frame update
    
    
    void Start()
    {
        if(NetworkManager.Singleton.IsHost)
        {
            red_player.AttachPlayer();
            return;
        }
        else
        {
            blue_player.AttachPlayer();
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
