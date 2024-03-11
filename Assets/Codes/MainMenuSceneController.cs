using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneController : MonoBehaviour
{
    private GameManager gameManager;
    

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
        gameManager.exposureAmount = 1f;
        RenderSettings.skybox.SetFloat("_Exposure", gameManager.exposureAmount);
        DynamicGI.UpdateEnvironment();
    }

}
