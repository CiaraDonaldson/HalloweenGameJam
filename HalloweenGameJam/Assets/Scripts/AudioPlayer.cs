using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay;


    void Start()
    {

        audioSource.PlayDelayed(delay);
    }
}
