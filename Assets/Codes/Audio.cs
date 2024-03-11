using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioClip gameMusic;
    public Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        gameMusic = GetComponent<AudioClip>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
