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
    public void OnOptionsPress() => SceneManager.LoadScene("SCN_OptionsScene", LoadSceneMode.Single);
    public void OnControlsPress() => SceneManager.LoadScene("SCN_ControlsScene", LoadSceneMode.Single);
    public void OnMainMenuPress() => SceneManager.LoadScene("SCN_MainMenu", LoadSceneMode.Single);
    public void OnQuitPress() => Application.Quit();

    public void OnPausePress()
    {
        pausePressed = true;
        pausingScript.CheckForPause();
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            OnPausePress();
        }
    }
}
