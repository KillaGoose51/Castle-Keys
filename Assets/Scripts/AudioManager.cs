using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;


    public static AudioManager Instance { get { return instance; } }

    private AudioSource gameMusic;
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
        gameMusic = GetComponent<AudioSource>();

    }

    private void Update()
    {
        
    }
   


}
