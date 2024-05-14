using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Button[] buttons;
    public TextMeshProUGUI[] Buttontext;
    public bool night = false;
    // Start is called before the first frame update
    void Start()
    {
        DayTime();
    }

    // Update is called once per frame
    public void ColorChanged()
    {
        if (night == true)
        {
            {
                DayTime();
            }
        }
        else if (night == false)
        {
                NightTime();
        }
#if UNITY_WSA

#else
        EventSystem.current.SetSelectedGameObject(null);
#endif
    }
    void DayTime()
    {
        night = false;
        foreach (Button button in buttons)
        {
            ColorBlock buttonColors = button.colors;
            buttonColors.highlightedColor = new Color(1, 1, 1);
//            buttonColors.selectedColor = new Color(0, 0, 0);
            buttonColors.normalColor = new Color(0, 0, 0);
            button.colors = buttonColors;
        }
    }
    void NightTime()
    {
        night = true;
        foreach (Button button in buttons)
        {
            ColorBlock buttonColors = button.colors;
            buttonColors.highlightedColor = new Color(0, 0, 0);
//            buttonColors.selectedColor = new Color(1, 1, 1);
            buttonColors.normalColor = new Color(1, 1, 1);
            button.colors = buttonColors;
        }
    }
}

