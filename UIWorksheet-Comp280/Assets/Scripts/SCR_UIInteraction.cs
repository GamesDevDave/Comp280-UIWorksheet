using UnityEngine;
using UnityEngine.SceneManagement;

public class SCR_UIInteraction : MonoBehaviour
{

    [Tooltip("Script that has the pausing related code.")]
    private SCR_Pausing pausingScript;
    public bool pausePressed;

    private void Start()
    {
        pausingScript = GetComponent<SCR_Pausing>();
    }

    // Used whenever the play button has been pressed by the user.
    public void OnPlayPress() => SceneManager.LoadScene("SCN_MainGameScene", LoadSceneMode.Single);
    public void OnOptionsPress() => SceneManager.LoadScene("SCN_OptionsScene", LoadSceneMode.Additive);
    public void OnControlsPress() => SceneManager.LoadScene("SCN_ControlsScene", LoadSceneMode.Additive);
    public void OnMainMenuPress() => SceneManager.LoadScene("SCN_MainMenu", LoadSceneMode.Single);
    public void OnQuitPress() => Application.Quit();

    private void Update()
    {
        if (pausePressed == false && Input.GetKeyDown(KeyCode.Escape))
        {
            pausePressed = true;
            pausingScript.CheckForPause();
            Debug.Log("Pause: True");
        }

        else if (pausePressed && Input.GetKeyDown(KeyCode.Escape))
        {
            pausePressed = false;
            pausingScript.CheckForUnpause();
            Debug.Log("Pause: False");
        }
    }
    public void OnUnloadScene(int sceneNumber)
    {
        SceneManager.UnloadSceneAsync(sceneNumber);
    }
}
