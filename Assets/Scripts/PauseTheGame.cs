using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PauseTheGame : MonoBehaviour
{
    public GameObject Pause;
    public GameObject UnPause;
    public FireCannon FireCannon;
    public bool GameIsPause;
    public Sprite unpauseSprite;
    public Sprite pauseSprite;
    private Image pauseImage;
    public AudioSource musicSource;

    public List<GameObject> spawnedInEnemies;

    // Start is called before the first frame update

    private void Start()
    {
        pauseImage = GetComponent<Image>();
    }
    void Update()
    {
        if (GameIsPause == true)
        {
            FireCannon.enabled = false;
            
            
        }
        try
        {
            musicSource = GameObject.Find("AudioManager").GetComponent<AudioSource>();
        }
        catch { }
    }
    public void PauseUnpause()
    {
        GameIsPause = !GameIsPause;
        if (GameIsPause == true)
        {
            Time.timeScale = 0;
            pauseImage.sprite = pauseSprite;
            musicSource.Pause();
        }
        else
        {
            Time.timeScale = 1;
            pauseImage.sprite = unpauseSprite;
            musicSource.UnPause();
        }
    }

    public void ControllerPauseUnpause(InputAction.CallbackContext context)
    {
        if (context.performed)
            PauseUnpause();
    }

}
