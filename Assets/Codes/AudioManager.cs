using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    
    public static AudioManager Instance { get { return instance; } }

    public AudioClip gameMusic;
    public Slider masterSlider, uiSlider, cannonSlider, musicSlider;
    public AudioMixer audioMixer;

    public TextMeshProUGUI[] TMPNumbers;
    [Header("Volume Integers")]
    public float masterVolumeInt, cannonVolumeInt, uiVolumeInt, musicVolumeInt;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        gameMusic = GetComponent<AudioClip>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMasterVolume(float soundLevel)
    {
        masterVolumeInt = masterSlider.value + 80;
        audioMixer.SetFloat("MasterVol", soundLevel);
        TMPNumbers[0].text = masterVolumeInt.ToString();
        PreferencesManager.SetMasterVolume(soundLevel);

    }

    public void SetCannonVolume(float soundLevel)
    {
        cannonVolumeInt = cannonSlider.value + 80;
        audioMixer.SetFloat("CannonVol", soundLevel);
        TMPNumbers[1].text = cannonVolumeInt.ToString();
        PreferencesManager.SetCannonVolume(soundLevel);

    }

    public void SetUIVolume(float soundLevel)
    {
        uiVolumeInt = uiSlider.value + 80;
        audioMixer.SetFloat("UiVol", soundLevel);
        TMPNumbers[2].text = uiVolumeInt.ToString();
        PreferencesManager.SetUiVolume(soundLevel);

    }
    public void SetMusicVolume(float soundLevel)
    {
        musicVolumeInt = musicSlider.value + 80;
        audioMixer.SetFloat("MusicVol", soundLevel);
        TMPNumbers[3].text = musicVolumeInt.ToString();
        PreferencesManager.SetMusicVolume(soundLevel);

    }
    
}
