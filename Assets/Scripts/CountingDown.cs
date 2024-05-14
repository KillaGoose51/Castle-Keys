using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountingDown : MonoBehaviour
{
    public int i;
    public TextMeshProUGUI cdTMP;
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

            i--;
            cdTMP.text = i.ToString();

            if (i == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
