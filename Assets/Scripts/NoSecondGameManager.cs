using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSecondGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try {
        Destroy(GameObject.Find("GameManager"));
    }
        catch { Debug.Log("The game manager has already been deleted"); }
    }
}
