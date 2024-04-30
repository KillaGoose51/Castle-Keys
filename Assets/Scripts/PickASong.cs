using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PickASong : MonoBehaviour
{
    public Animator Left;
    public Animator Center;
    public Animator Right;
    
    public int animCount = 1;
    public bool isCoolDownActive = false;

    public MusicController musicController;

    public Color32 enabledColor;
    public Color32 disabledColor = Color.white;

    private void Start()
    {
        StartCoroutine(StartMusic());

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AnimCountUp();
        }
        
        Debug.Log(animCount);


    }

    IEnumerator StartMusic()
    {
        yield return new WaitForSeconds(0.1f);
        ChangeSong();
        musicController.audioController.Play();
    }
    public void AnimCountUp()
    {
        if (isCoolDownActive == false)
        {
            ++animCount;
            StartCoroutine(ButtonCoolDown(0.90f));


            if (animCount == 1)
            {
                Left.SetInteger("animCount", 1);
                Center.SetInteger("animCount", 1);
                Right.SetInteger("animCount", 1);
            }
            if (animCount == 2)
            {
                Left.SetInteger("animCount", 2);
                Center.SetInteger("animCount", 2);
                Right.SetInteger("animCount", 2);
            }
            if (animCount == 3)
            {
                Left.SetInteger("animCount", 3);
                Center.SetInteger("animCount", 3);
                Right.SetInteger("animCount", 3);
                animCount = 0;
            }
            ChangeSong();
        }

        isCoolDownActive = true;


    }

    public void ChangeSong()
    {
        

         switch (animCount)
         {
             case 0:
                 musicController.audioController.clip = musicController.musicList[0];
                 musicController.songName.text = "Song\nChill With Me";
                StartCoroutine(ColorChange(Center));
                StartCoroutine(ColorChangeOff(Right));
                StartCoroutine(ColorChangeOff(Left));
                Debug.Log("First song is being playing");
                 break;
             case 1:
                 musicController.audioController.clip = musicController.musicList[1];
                 musicController.songName.text ="Song\nSleepy Time";
                StartCoroutine(ColorChange(Right));
                StartCoroutine(ColorChangeOff(Center));
                StartCoroutine(ColorChangeOff(Left));
                Debug.Log("Second Song is being played");
                 break;
             case 2:
                 musicController.audioController.clip = musicController.musicList[2];
                 musicController.songName.text = "Song\nSle" +
                    "ep Walking";
                StartCoroutine(ColorChange(Left));
                StartCoroutine(ColorChangeOff(Center));
                StartCoroutine(ColorChangeOff(Right));
                Debug.Log("Third song is being played");
                 break;
             default:
                 musicController.audioController.clip = musicController.musicList[0];
                 Debug.Log("No Song Selectected");
                 break;
         }
        musicController.audioController.Play();

    }

    IEnumerator ColorChange(Animator blockChoice)
    {
        yield return new WaitForSeconds(0.8f);
        blockChoice.gameObject.GetComponent<Image>().color = enabledColor;
        Debug.Log("Called");
    }
    IEnumerator ColorChangeOff(Animator blockChoice)
    {
        yield return new WaitForSeconds(0.8f);
        blockChoice.gameObject.GetComponent<Image>().color = disabledColor;
        Debug.Log("Called Off");
    }

    public IEnumerator ButtonCoolDown(float cooldownAmount)
    {
        yield return new WaitForSeconds(cooldownAmount);
        isCoolDownActive = false;
    }

}

