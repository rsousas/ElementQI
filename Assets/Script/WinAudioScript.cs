using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAudioScript : MonoBehaviour {

    public static AudioClip aplausos;

    public static AudioSource audioSrc;
    // Use this for initialization
    void Start()
    {
        aplausos = Resources.Load<AudioClip>("aplausos");

        audioSrc = GetComponent<AudioSource>();
        audioSrc.PlayOneShot(aplausos);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
