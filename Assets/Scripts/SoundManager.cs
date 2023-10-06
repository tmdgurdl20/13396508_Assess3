using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip intro;
    public AudioClip normalState;

    AudioSource audioPlay;
    // Start is called before the first frame update
    void Start()
    {
        audioPlay = GetComponent<AudioSource>();
        StartCoroutine(PlayMusic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayMusic()
    {
        audioPlay.clip = intro;
        audioPlay.Play();
        yield return new WaitForSeconds(10.0f);

        audioPlay.clip = normalState;
        audioPlay.loop = true;
        audioPlay.Play();

    }
}
