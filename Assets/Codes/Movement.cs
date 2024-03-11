using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public int rotatespeedx;
    public int rotatespeedy;
    public int rotatespeedz;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotatespeedx, rotatespeedy, rotatespeedz);
    }
}
