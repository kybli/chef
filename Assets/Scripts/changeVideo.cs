using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class changeVideo : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private VideoClip[] videoClips;
    
    void Start()
    {
        isPressed = false;

        videoPlayer.clip = videoClips[0];
        videoPlayer.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject== presser)
        {
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SwitchVideoClip(int index)
    {
        videoPlayer.Stop(); // Stop the current video clip
        videoPlayer.clip = videoClips[index]; // Set the new video clip
        videoPlayer.Play(); // Play the new video clip 
    }
}
