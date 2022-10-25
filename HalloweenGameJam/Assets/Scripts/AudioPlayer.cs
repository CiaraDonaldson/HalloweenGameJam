using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource Audio;
    public int seconds = 3;
    // Start is called before the first frame update
    void Start()
    {
        playAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator playAudio()
    {
        yield return new WaitForSeconds(seconds);
        Audio.Play(0);
    }
}
