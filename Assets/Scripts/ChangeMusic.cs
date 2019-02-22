using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public AudioClip level2Music;

    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnLevelFinishedLoading(int level)
    {
        if (level == 2)
        {
            source.clip = level2Music;
            source.Play();
        }
    }
}
