using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FireCannon : MonoBehaviour
{
    public GameObject CannonUp;
    public GameObject CannonLeft;
    public GameObject CannonRight;
    public GameObject CannonDown;
    public GameObject Bullet;
    public GameObject MoveLight;
    public Rigidbody lRb;
    public float cooldownthing;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            FireLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            FireRight();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            FireUp();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            FireDown();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (cooldownthing == 0)
        {
            GoBackToZero();
        }

    }
    public IEnumerator GoBackToZero()
    {
        {
            yield return new WaitForSeconds(cooldownthing);
            {

                cooldownthing -= Time.deltaTime;
                lRb.transform.localPosition = Vector3.zero * Time.smoothDeltaTime;
                lRb.velocity = Vector3.zero;
                cooldownthing = 0;
            }

        }
    }

    public void FireLeft()
    {
        GameObject clone = Instantiate(Bullet, CannonLeft.transform.position, Quaternion.identity);
        clone.tag = "LeftCannon";
        clone.GetComponent<Bullet>().slowdownovertime = 10;
        clone.GetComponent<Bullet>().FireBullet();
        cooldownthing += 0.1f;
    }
    public void FireRight()
    {
        GameObject clone = Instantiate(Bullet, CannonRight.transform.position, Quaternion.identity);
        clone.tag = "RightCannon";
        clone.GetComponent<Bullet>().slowdownovertime = 10;
        clone.GetComponent<Bullet>().FireBullet();
        cooldownthing += 0.1f;
    }
    public void FireUp()
    {
        GameObject clone = Instantiate(Bullet, CannonUp.transform.position, Quaternion.identity);
        clone.tag = "UpCannon";
        clone.GetComponent<Bullet>().slowdownovertime = 10;
        clone.GetComponent<Bullet>().FireBullet();
        cooldownthing += 0.1f;
    }
    public void FireDown()
    {
        GameObject clone = Instantiate(Bullet, CannonDown.transform.position, Quaternion.identity);
        clone.tag = "DownCannon";
        clone.GetComponent<Bullet>().slowdownovertime = 10;
        clone.GetComponent<Bullet>().FireBullet();
        cooldownthing += 0.1f;
    }
}
