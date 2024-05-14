using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private EnemySpawn eSpawn;
    MainMenuSceneController mainSceneController;
    public static GameManager instance;

    public int diffChooser;
    bool DayDay = true;
    public float exposureAmount;
    public Renderer rend;

    public AudioSource selectAS;

    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        SceneManager.sceneLoaded += DayNightCycle;
        selectAS.clip = null;

    }
    void Update()
    {
        
        try
        {
            eSpawn = GameObject.Find("EnemySpawner").GetComponent<EnemySpawn>();
            eSpawn.difchoose = diffChooser;
        }
        catch
        {
           //S Debug.Log("No Enemy Spawner could be found");
        }


    }
    private void DayNightCycle(Scene arg0, LoadSceneMode arg1)
    {
        if (GameManager.Instance.tag == "Day")
        {
            DayDay = true;
            exposureAmount = 1f;
        }
        else if (GameManager.Instance.tag == "Night")
        {
            DayDay = false;
            exposureAmount = 0.1f;
        }
        try
        {
            RenderSettings.skybox.SetFloat("_Exposure", exposureAmount);
        }
        catch { }
        DynamicGI.UpdateEnvironment();
    }




    public void DayNight()
    {
        DayDay = !DayDay;
        if (DayDay == true)
        {
            tag = "Day";
            exposureAmount = 1f;
            DynamicGI.UpdateEnvironment();
        }
        else
        {
            tag = "Night";
            exposureAmount = 0.1f;
            DynamicGI.UpdateEnvironment();
        }
        if (GameManager.Instance.tag == "Day")
        {
            exposureAmount = 1f;
        }
        else if (GameManager.Instance.tag == "Night")
        {
            exposureAmount = 0.1f;
        }
        RenderSettings.skybox.SetFloat("_Exposure", exposureAmount);
        DynamicGI.UpdateEnvironment();
    }

public void ButtonSound()
    {
        selectAS.Play();
    }



}
