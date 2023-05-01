using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private VideoPlayer videoPlayer;

    [SerializeField] private GameObject playIcon;
    [SerializeField] private GameObject pauseIcon;
    [SerializeField] private GameObject muteIcon;
    [SerializeField] private GameObject unmuteIcon;
    [SerializeField] private GameObject menu;
    [SerializeField] private VideoClip[] videoClips;
    [SerializeField] private GameObject showMenuIcon;
    [SerializeField] private GameObject hideMenuIcon;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    public void PlayAndPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playIcon.SetActive(true);
            pauseIcon.SetActive(false);
        }
        else
        {
            videoPlayer.Play();
            playIcon.SetActive(false);
            pauseIcon.SetActive(true);
        }
    }

    public void forward()
    {
        videoPlayer.time += 10.0f;
    }

    public void backward()
    {
        videoPlayer.time -= 10.0f;
    }

    public void muteVideo()
    {
        if (videoPlayer.GetDirectAudioMute(0))
        {
            videoPlayer.SetDirectAudioMute(0, false);
            muteIcon.SetActive(false);
            unmuteIcon.SetActive(true);
        }
        else
        {
            videoPlayer.SetDirectAudioMute(0, true);
            muteIcon.SetActive(true);
            unmuteIcon.SetActive(false);
        }
    }

    public void toggleMenu()
    {
        if (menu.activeSelf)
        {
            menu.SetActive(false);
            showMenuIcon.SetActive(true);
            hideMenuIcon.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
            showMenuIcon.SetActive(false);
            hideMenuIcon.SetActive(true);
        }
    }

    public void SwitchVideoClip(int index)
    {
        videoPlayer.Stop(); // Stop the current video clip
        videoPlayer.clip = videoClips[index]; // Set the new video clip
        videoPlayer.Play(); // Play the new video clip 
    }
}
