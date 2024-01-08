using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnThreshold = 3f;
    public int frequency = 0;
    public float cooldown = 0;
    public float spawncount = 0;
    public FFTWindow fftWindow;
    private float[] samples = new float[1024];
    public float debugValue;
    // Start is called before the first frame update
    void Start()
    {
        spawncount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        AudioListener.GetSpectrumData(samples, 0, fftWindow);

        debugValue = samples[frequency];

        if (samples[frequency] > spawnThreshold && spawncount == 0)
        {
            Instantiate(objectPrefab, transform.position, transform.rotation);
            spawncount++;
            cooldown = frequency;
        }
        
    }
}
