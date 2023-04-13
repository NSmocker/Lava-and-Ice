using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TrackableModelAttacherSystem : MonoBehaviour
{

    public PlayerSystem master_system;

    public CharacterAvatarSystem character_avatar_system;
    public TrackablesLibrary trackables_library;

    public Vector3 body_offset;

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
        if (character_avatar_system == null)
        {
            Debug.LogError("No character avatar system; Cannot attach models to trackables!!");
        }
        else 
        {
            character_avatar_system.head.transform.position = trackables_library.eyes_trackable.transform.position;
            character_avatar_system.head.transform.rotation = trackables_library.eyes_trackable.transform.rotation;

            character_avatar_system.left_hand.transform.position = trackables_library.left_hand_trackable.transform.position;
            character_avatar_system.left_hand.transform.rotation = trackables_library.left_hand_trackable.transform.rotation;

            character_avatar_system.right_hand.transform.position = trackables_library.right_hand_trackable.transform.position;
            character_avatar_system.right_hand.transform.rotation = trackables_library.right_hand_trackable.transform.rotation;

            
            character_avatar_system.body.transform.position = trackables_library.eyes_trackable.transform.position + body_offset;
            var body_re_angle = new Vector3(0,trackables_library.eyes_trackable.transform.eulerAngles.y,0);
            character_avatar_system.body.transform.eulerAngles = body_re_angle;
            



        }

    }
}
