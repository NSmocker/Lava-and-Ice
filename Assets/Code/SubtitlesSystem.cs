using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SubtitlesSystem : MonoBehaviour
{
    public string text_to_show;
    public TextMeshPro text_display;
    public int character_id;
    public float time_to_next_character;
    public Animator animation_system;
  

    public void AnimateSubtitles(string text)
    {
        animation_system.SetTrigger("Показати");
        text_to_show = text;
        text_display.text = text;
     
    }

    public void HideSubtitles() 
    {
        animation_system.SetTrigger("Сховати");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
