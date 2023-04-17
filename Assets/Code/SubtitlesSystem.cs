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
    public IEnumerator ProccessText()
    {
        while (character_id != text_to_show.Length - 1) 
        {
            yield return new WaitForSeconds(time_to_next_character);
            text_display.text += text_to_show[character_id];
            character_id++;
        }


    }

    public void AnimateSubtitles(string text)
    {
        animation_system.SetTrigger("Показати");
        text_to_show = text;
        text_display.text = "";
        ProccessText();
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
