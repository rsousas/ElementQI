using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    public static AudioClip erro, acerto, questionario, musica, aplausos;

    public static AudioSource audioSrc;
    // Use this for initialization
    void Start () {
        erro = Resources.Load<AudioClip>("erro");
        acerto = Resources.Load<AudioClip>("acerto");
        questionario = Resources.Load<AudioClip>("questionario");
        musica = Resources.Load<AudioClip>("musica");

        audioSrc = GetComponent<AudioSource>();
        audioSrc.PlayOneShot(musica);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "erro":
                audioSrc.PlayOneShot(erro);
                break;
            case "acerto":
                audioSrc.PlayOneShot(acerto);
                break;
            case "questionario":
                audioSrc.PlayOneShot(questionario);
                break;
            case "musica":
                audioSrc.PlayOneShot(musica);
                break;

        }
    }
}
