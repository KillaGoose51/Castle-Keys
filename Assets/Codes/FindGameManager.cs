using UnityEngine;
using UnityEngine.UI;

public class FindGameManager : MonoBehaviour
{
    public GameManager manager;
    public Button sbutton;
    public GameObject SettingsButton;

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        catch
        { }
    }
}
