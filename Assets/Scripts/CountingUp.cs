using System.Collections;
using UnityEngine;

public class CountingUp : MonoBehaviour
{
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountEverySecond());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CountEverySecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            i++; 
                Debug.LogWarning(i);
            
            
        }
    }
}

