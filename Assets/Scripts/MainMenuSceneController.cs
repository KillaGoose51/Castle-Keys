using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneController : MonoBehaviour
{
    private GameManager gameManager;

    private GameObject Scene1;

    public AudioManager audioManager;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        catch { }

        try
        {
            audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        }
        catch { }

    }

    
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1);
    }
    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);

    }

    public void SetDifficulty(int DifChooseAssigner)
    {
        gameManager.diffChooser = DifChooseAssigner;
    }

    public void LeaveNOW()
    {
#if UNITY_EDITOR
        gameManager.exposureAmount = 1f;
        RenderSettings.skybox.SetFloat("_Exposure", gameManager.exposureAmount);
        DynamicGI.UpdateEnvironment();
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif

    }

    private void OnApplicationQuit()
    {

        RenderSettings.skybox.SetFloat("_Exposure", gameManager.exposureAmount);
        DynamicGI.UpdateEnvironment();
    }

}
