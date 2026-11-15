using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        Button[] buttons = FindObjectsByType<Button>(FindObjectsInactive.Include);
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(PlaySound);
        }
    }

    public void PlaySound()
    {
        // Play the sound effect
        audioSource.Play();
    }
}