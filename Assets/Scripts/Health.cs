using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI healthpoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthpoints.text = health.ToString();
    }
    public void GetHurt()
    {
        --health;
    }
}
