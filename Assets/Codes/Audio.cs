using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip gameMusic;
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
