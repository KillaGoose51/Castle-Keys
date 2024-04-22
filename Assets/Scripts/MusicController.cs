using TMPro;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioManager audioManager;
    public AudioSource audioController;
    public AudioClip[] musicList;
    public int MusicChoice = 1;
    public bool firstsong = false, secondSong = false, Thirdsong = false;

    public TextMeshProUGUI songName;

    public PickASong pickASong;

    private void Start()
    {
        audioController.Play();
        try
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
        catch { }
    }

    private void Update()
    {
        try { audioController = GameObject.Find("AudioManager").GetComponent<AudioSource>(); } catch { Debug.Log("Did not find a audio source"); }
        MusicChoice = pickASong.animCount;

        //test to see which is active
        if (pickASong.animCount == 0)
        {
            firstsong = true;
        }
        else firstsong = false;
        if (pickASong.animCount == 1)
        {
            secondSong = true;
        }
        else secondSong = false;

        if (pickASong.animCount == 2)
        {
            Thirdsong = true;
        }
        else Thirdsong = false;
    }
    

    
    
}
