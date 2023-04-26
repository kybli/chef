using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    [SerializeField] private Transform video;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private float resizeSpeed = 0.5f;
    [SerializeField] private float minSize = 0.1f;
    [SerializeField] private float maxSize = 1f;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
        }

        float sizeDelta = 0;

        // Check for arrow key input and calculate the size delta
        if (Input.GetKey(KeyCode.UpArrow)) {
            sizeDelta += resizeSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            sizeDelta -= resizeSpeed * Time.deltaTime;
        }

        // Resize the video
        float newSize = Mathf.Clamp(video.localScale.x + sizeDelta, minSize, maxSize);
        video.localScale = new Vector3(newSize, newSize, newSize);
    }
}
