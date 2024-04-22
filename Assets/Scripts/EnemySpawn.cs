using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject objectPrefab;
    public Transform[] spawnpos;
    public float cooldown = 3;
    public int difchoose;
    int intR;
    float randomtimeeasy;
    float randomtimemedium;
    float randomtimehard;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    cooldown -= Time.deltaTime;

        if (cooldown <= 0)
        {
            enemyspawning();
        }
    }
    public void enemyspawning()
    {
        // Picks a random value for the spawning time.
        RandomValues();
        // Picks difficulty at the start, 1 = easy, 2 = medium, 3 = hard
        switch (difchoose)
        {
            case 1:
                //intR picks random spawn area
                Instantiate(objectPrefab, spawnpos[intR].position, transform.rotation);
                cooldown += randomtimeeasy;
                break;
            case 2:
                Instantiate(objectPrefab, spawnpos[intR].position, transform.rotation);
                cooldown += randomtimemedium;
                break;
            case 3:
                Instantiate(objectPrefab, spawnpos[intR].position, transform.rotation);
                cooldown += randomtimehard;
                break;
            default:
                Debug.Log("No Difficulty Selectected");
                break;
        }
    }
    void RandomValues()
    {
        intR = Random.Range(0, 4);
        randomtimeeasy = Random.Range(3f, 5f);
        randomtimemedium = Random.Range(1f, 3f);
        randomtimehard = Random.Range(0.1f, 0.4f);
    }
}
