using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip[] AudioBGMArr;

    private float musicVolume = 1f;
    private float volDown = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //audioSource.Play();
            int rand = Random.Range(0, AudioBGMArr.Length);
        }
    }
}
