using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
    public GameObject CannonUp;
    public GameObject CannonLeft;
    public GameObject CannonRight;
    public GameObject CannonDown;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {

            GameObject clone = Instantiate(Bullet, CannonLeft.transform.position, Quaternion.identity);
            clone.tag = "LeftCannon";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject clone = Instantiate(Bullet, CannonRight.transform.position, Quaternion.identity);
            clone.tag = "RightCannon";
        }
       if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject clone = Instantiate(Bullet, CannonUp.transform.position, Quaternion.identity);
            clone.tag = "UpCannon";
        }
       if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject clone = Instantiate(Bullet, CannonDown.transform.position, Quaternion.identity);
            clone.tag = "DownCannon";
        }
    }
}
