using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PreferencesManager // public file
{
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("MusicVolume", 1);
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume", 1);
    }

    public static void SetMusicVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }
    public static void SetMasterVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }
    public static void SetCannonVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("CannonVolume", soundLevel);
    }
    public static void SetUiVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("UiVolume", soundLevel);
    }
}
