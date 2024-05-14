using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

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
    public bool firingU, firingD, firingL, firingR;
    public PauseTheGame PauseTheGame;

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
        if (Time.timeScale != 0)
        {
            GameObject clone = Instantiate(Bullet, CannonLeft.transform.position, Quaternion.identity);
            clone.tag = "LeftCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
            
        }
    }
    public void FireRight()
    {
        if (Time.timeScale != 0)
        {
            GameObject clone = Instantiate(Bullet, CannonRight.transform.position, Quaternion.identity);
            clone.tag = "RightCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }
    public void FireUp()
    {
        if (Time.timeScale != 0)
        {
            GameObject clone = Instantiate(Bullet, CannonUp.transform.position, Quaternion.identity);
            clone.tag = "UpCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }
    public void FireDown()
    {
        if (Time.timeScale != 0)
        {
            GameObject clone = Instantiate(Bullet, CannonDown.transform.position, Quaternion.identity);
            clone.tag = "DownCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }


    public void ControllerFireLeft(InputAction.CallbackContext context)
    {
        if (Time.timeScale != 0 && context.performed)
        {
            GameObject clone = Instantiate(Bullet, CannonLeft.transform.position, Quaternion.identity);
            clone.tag = "LeftCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }
    public void ControllerFireRight(InputAction.CallbackContext context)
    {
        if (Time.timeScale != 0 && context.performed)
        {
            GameObject clone = Instantiate(Bullet, CannonRight.transform.position, Quaternion.identity);
            clone.tag = "RightCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }
    public void ControllerFireUp(InputAction.CallbackContext context)
    {
        if (Time.timeScale != 0 && context.performed)
        {
            GameObject clone = Instantiate(Bullet, CannonUp.transform.position, Quaternion.identity);
            clone.tag = "UpCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }
    public void ControllerFireDown(InputAction.CallbackContext context)
    {
        if (Time.timeScale != 0 && context.performed )
        {
            GameObject clone = Instantiate(Bullet, CannonDown.transform.position, Quaternion.identity);
            clone.tag = "DownCannon";
            clone.GetComponent<Bullet>().slowdownovertime = 10;
            clone.GetComponent<Bullet>().FireBullet();
            cooldownthing += 0.1f;
        }
    }
    public void OnFiringUp(InputValue value)
    {
        firingU = value.isPressed;
    }
    public void OnFiringDown(InputValue value)
    {
        firingD = value.isPressed;
    }
    public void OnFiringLeft(InputValue value)
    {
        firingL = value.isPressed;
    }
    public void OnFiringRight(InputValue value)
    {
        firingR = value.isPressed;
    }
}
