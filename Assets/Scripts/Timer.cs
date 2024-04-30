using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes = 0, seconds = 00;
    public string time = "0:00";

    private TextMeshProUGUI timerText;

    public TextMeshProUGUI songNameTmp;

    public int songChosen;

    private AudioManager audioManager;

    public int[] minutesForSongs =
    {
        3,
        2,
        4
    };
    public int[] secondsForSongs =
    {
        32,
        42,
        24
    };

    public string[] songNames =
    {
        "Chill With Me",
        "Sleepy Time",
        "Sleep Walking"
    };

    public bool timeStarted = true;

    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();

        songChosen = audioManager.songChosen;
        switch (songChosen)
        {
            case 0:
                minutes = minutesForSongs[0];
                seconds = minutesForSongs[0];
                songNameTmp.text = songNames[0];
                break;
            case 1:
                minutes = minutesForSongs[1];
                seconds = minutesForSongs[1];
                songNameTmp.text = songNames[1];
                break;
            case 2:
                minutes = minutesForSongs[2];
                seconds = minutesForSongs[2];
                songNameTmp.text = songNames[2];
                break;

            default:
                minutes = 0;
                seconds = 0;
                break;
        }

        if (seconds > 9)
        {
            time = minutes + ":" + seconds;

        }
        else time = minutes + ":0" + seconds;

        timerText.text = time;
    }
    private void Update()
    {
        try { audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>(); } catch { }
        songChosen = audioManager.songChosen;

        if (timeStarted == true)
        {
            switch (songChosen)
            {
                case 0:
                    minutes = minutesForSongs[0];
                    seconds = secondsForSongs[0];
                    songNameTmp.text = songNames[0];
                    break;
                case 1:
                    minutes = minutesForSongs[1];
                    seconds = secondsForSongs[1];
                    songNameTmp.text = songNames[1];
                    break;
                case 2:
                    minutes = minutesForSongs[2];
                    seconds = secondsForSongs[2];
                    songNameTmp.text = songNames[2];
                    break;

                default:
                    minutes = 0;
                    seconds = 0;
                    break; 
            }

            if (seconds > 9)
            {
                time = minutes + ":" + seconds;

            }
            else time = minutes + ":0" + seconds;

            timerText.text = time;



            StartCoroutine(CountingTimerDown());
            timeStarted = false;
        }
    }
    public IEnumerator CountingTimerDown()
    {
        while (true)
        {

            yield return new WaitForSeconds(1);

            if (seconds == 0)
            {
                minutes--;
                seconds = 59;
            }
            else seconds--;

            if (seconds > 9)
            {
                time = minutes + ":" + seconds;

            }
            else time = minutes + ":0" + seconds;

            timerText.text = time;

            if (time == "0:00") break;
        }
    }



}
