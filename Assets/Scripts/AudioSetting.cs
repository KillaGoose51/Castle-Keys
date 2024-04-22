using TMPro;
using UnityEngine;
using UnityEngine.Audio;

using UnityEngine.UI;


public class AudioSetting : MonoBehaviour
{
    public GameManager manager;
    public Button sbutton;
    public GameObject SettingsButton;
    public AudioManager audioManager;

    public Slider masterSlider, uiSlider, cannonSlider, musicSlider;
    public AudioMixer audioMixer;

    public TextMeshProUGUI[] TMPNumbers;
    [Header("Volume Integers")]
    public float masterVolumeInt, cannonVolumeInt, uiVolumeInt, musicVolumeInt;

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (masterSlider == null)
            {
                masterSlider = GameObject.Find("Master Volume").GetComponent<Slider>();
            }
        }
        catch { }
        try
        {
            if (uiSlider == null)
            {
                uiSlider = GameObject.Find("UIVolume").GetComponent<Slider>();
            }
        }
        catch { }
        try
        {
            if (musicSlider == null)
            {
                musicSlider = GameObject.Find("MusicVolume").GetComponent<Slider>();
            }
        }
        catch { }

        try
        {
            if (cannonSlider == null)
            {
                cannonSlider = GameObject.Find("CannonVolume").GetComponent<Slider>();
            }
        }
        catch { }
        try
        {
            if (TMPNumbers[0] == null) { TMPNumbers[0] = GameObject.Find("MasterVolumeNumber").GetComponent<TextMeshProUGUI>(); }
            if (TMPNumbers[1] == null) { TMPNumbers[1] = GameObject.Find("CannonNumber").GetComponent<TextMeshProUGUI>(); }
            if (TMPNumbers[2] == null) { TMPNumbers[2] = GameObject.Find("UINumber").GetComponent<TextMeshProUGUI>(); }
            if (TMPNumbers[3] == null) { TMPNumbers[3] = GameObject.Find("MusicNumber").GetComponent<TextMeshProUGUI>(); }
        }
        catch { }
    }

    public void SetMasterVolume(float soundLevel)
    {
        masterVolumeInt = masterSlider.value + 80;
        audioMixer.SetFloat("MasterVol", masterVolumeInt - 80);
        TMPNumbers[0].text = masterVolumeInt.ToString();
        PreferencesManager.SetMasterVolume(soundLevel);

    }

    public void SetCannonVolume(float soundLevel)
    {
        cannonVolumeInt = cannonSlider.value + 80;
        audioMixer.SetFloat("CannonVol", cannonVolumeInt - 80);
        TMPNumbers[1].text = cannonVolumeInt.ToString();
        PreferencesManager.SetCannonVolume(soundLevel);

    }

    public void SetUIVolume(float soundLevel)
    {
        uiVolumeInt = uiSlider.value + 80;
        audioMixer.SetFloat("UiVol", uiVolumeInt - 80);
        TMPNumbers[2].text = uiVolumeInt.ToString();
        PreferencesManager.SetUiVolume(soundLevel);

    }
    public void SetMusicVolume(float soundLevel)
    {
        musicVolumeInt = musicSlider.value + 80;
        audioMixer.SetFloat("MusicVol", musicVolumeInt - 80);
        TMPNumbers[3].text = musicVolumeInt.ToString();
        PreferencesManager.SetMusicVolume(soundLevel);

    }

}
