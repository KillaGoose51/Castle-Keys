using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float speed = 10f;
    public GameObject castle;
    public Vector3 castlepos;
    // Start is called before the first frame update

    void Start()
    {
        castlepos = GameObject.FindGameObjectWithTag("Base").transform.position;

        castle = GameObject.FindWithTag("Base");
    }

    // Update is called once per frame
    void Update()
    {
        	transform.Translate ((castlepos - transform.position).normalized * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Base"))
        {
            collision.gameObject.GetComponent<Health>().GetHurt();
            Destroy(gameObject);   
        }
    }
}
