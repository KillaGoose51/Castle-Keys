using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject spawnerObject;
    public float slowdownovertime;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject.Find("EnemySpawner").GetComponent<EnemySpawn>();
        }

    }

    private void Update()
    {
        FireBullet();
    }
    // Update is called once per frame
    public void FireBullet()
    {
        if (slowdownovertime >= 0)
        {
            slowdownovertime -= Time.deltaTime * 3.5f;
        }
        if (CompareTag("LeftCannon"))
        {
            transform.Translate(Vector3.left * slowdownovertime * Time.deltaTime);
        }
        if (CompareTag("RightCannon"))
        {
            transform.Translate(Vector3.right * slowdownovertime * Time.deltaTime);
        }
        if (CompareTag("UpCannon"))
        {
            transform.Translate(Vector3.forward * slowdownovertime * Time.deltaTime);
        }
        if (CompareTag("DownCannon"))
        {
            transform.Translate(Vector3.back * slowdownovertime * Time.deltaTime);
        }
    }

}