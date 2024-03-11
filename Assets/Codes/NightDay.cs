using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NightDay : MonoBehaviour
{
    private TextMeshProUGUI dayAndNight;
    // Start is called before the first frame update
    void Start()
    {
        dayAndNight = GetComponentInChildren<TextMeshProUGUI>();
    }
    private void Update()
    {
        DayNight();
    }

    // Update is called once per frame
    public void DayNight()
    {

        if (GameManager.Instance.tag == "Day")        
            {
            gameObject.tag = "Day";
            dayAndNight.text = "Day";
            }
        else if (GameManager.Instance.tag == "Night")
        {
            gameObject.tag = "Night";
            dayAndNight.text = "Night";
        }
    }
    public void CallDayNight()
    {
        GameManager.Instance.DayNight();
    }
    
}
