using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiotoTitle : MonoBehaviour
{
    public bool Hasbeenseen;
    public GameObject AudioFirstText;
    public GameObject Title;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            AudioFirstText = GameObject.Find("AudioFirst");
            {
                
            }
            Title = GameObject.Find("Title");
            if (Hasbeenseen == true)
            {
                AudioFirstText.SetActive(false);
                Title.SetActive(true);
            }
        }
        catch
        {

        }
    }    
     public void BoolTrue()
    {
        Hasbeenseen = true;
    }
}
