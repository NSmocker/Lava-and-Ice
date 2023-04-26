using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
   public SubtitlesSystem subtitles_system;
    public string tooltip_text;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            subtitles_system.AnimateSubtitles(tooltip_text);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            subtitles_system.HideSubtitles();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        subtitles_system = GameObject.Find("Subtitles System").GetComponent<SubtitlesSystem>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
