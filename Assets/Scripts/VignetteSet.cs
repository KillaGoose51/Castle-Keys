using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VignetteSet : MonoBehaviour
{
    public GameObject Vignette;
    public Light MainLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.tag == "Day")
        {
            Vignette.SetActive(false);
        }
        else if (GameManager.Instance.tag != "Day")
        {
            Vignette.SetActive(true);
            MainLight.intensity = 500;
        }
    }
}
