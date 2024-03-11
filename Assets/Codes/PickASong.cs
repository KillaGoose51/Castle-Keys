using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickASong : MonoBehaviour
{
    public Animator Left;
    public Animator Center;
    public Animator Right;
    public int animCount;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AnimCountUp();
        }

    }

    public void AnimCountUp()
    {
        ++animCount;
        if (animCount == 1)
        {
            Left.SetInteger("animCount", 1);
            Center.SetInteger("animCount", 1);
            Right.SetInteger("animCount", 1);
        }
        if (animCount == 2)
        { Left.SetInteger("animCount", 2);
            Center.SetInteger("animCount", 2);
            Right.SetInteger("animCount", 2); }
        if (animCount == 3)
        { Left.SetInteger("animCount", 3);
            Center.SetInteger("animCount", 3);
            Right.SetInteger("animCount", 3); 
        animCount = 0; }
    }
}
