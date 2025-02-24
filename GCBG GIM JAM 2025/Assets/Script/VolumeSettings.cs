using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider MusicSlider;

    public void SetMusicVolume()
    {
        float volume = MusicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume)*10);
    }
}
