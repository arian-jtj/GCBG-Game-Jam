using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-----Audio Source-----")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;


    [Header("-----Audio Clip-----")]
    public AudioClip WorldBGM1;
    public AudioClip WorldBGM2;
    public AudioClip WorldBGM3;
    public AudioClip Walking;

    [Header("Audio Clip")]
    public AudioClip background;

    private void Start()
    {
        MusicSource.clip = background;
        MusicSource.Play();
    }

}
